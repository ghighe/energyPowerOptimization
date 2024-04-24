using System;
using System.Data;
using System.Windows.Forms;
using energyPowerOptimization.Products;
using OfficeOpenXml;


namespace energyPowerOptimization.userControls
{
    public partial class UC_adauga_consumatori : UserControl
    {
        private string consumWati = null;
        private string ore_utilizare = null;
        private string currentProduct = null;
        private bool wasWrittenToExcel = false;
        private int totalConsumptionDay = 0;
        private double totalConsumptionMonth = 0;
        private double totalConsumptionYear = 0;
        System.Collections.Generic.List<Product> products = ItemManager.GetHomeProducts();

        public UC_adauga_consumatori()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            LoadDataFromExcelFile();
            foreach (var product in products)
            {
                selecteazaProdus_comboBox.Items.Add(product.name);
            }
        }


        private void storeDataInExcelFile(
            String val1,
            String val2, 
            String val3,
            String val4,
            int val5,
            double val6,
            double val7)
        {
          
            using (var package = new ExcelPackage(new System.IO.FileInfo(Constants.filePath)))
            {
               //Console.WriteLine(package.Workbook.Worksheets.Count > 0);
                //selecteaza prima pagina a excelului la index 0
                if(package.Workbook.Worksheets.Count >= 0)
                {
                    ExcelWorksheet ws = package.Workbook.Worksheets[0];

                    //find the available row in excel
                    int rowIndex = ws.Dimension?.Rows ?? 1;
                    //MessageBox.Show(rowIndex.ToString());
                    //add headers in the first row
                    ws.Cells[1, 1].Value = "Produs";
                    ws.Cells[1, 2].Value = "kWh/zi";
                    ws.Cells[1, 3].Value = "kWh/luna";
                    ws.Cells[1, 4].Value = "kWh/an";
                    ws.Cells[1, 5].Value = "totalEnergieZi";
                    ws.Cells[1, 6].Value = "totalEnergieLuna";
                    ws.Cells[1, 7].Value = "totalEnergieAn";

                    rowIndex++;
                    //add data to the available row
                    ws.Cells[rowIndex, 1].Value = val1;
                    ws.Cells[rowIndex, 2].Value = val2;
                    ws.Cells[rowIndex, 3].Value = val3;
                    ws.Cells[rowIndex, 4].Value = val4;
                    ws.Cells[2, 5].Value = val5;
                    ws.Cells[2, 6].Value = val6;
                    ws.Cells[2, 7].Value = val7;
                    rowIndex++;
                }
                //save changes
               try
                {
                    package.Save();
                }catch(Exception ex)
                {
                   MessageBox.Show("Nu s-a putut salva in fisierul excel, verificati daca acesta este deschis! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                wasWrittenToExcel = true;
            }
           // MessageBox.Show("Data added successfully to DB");
        }

        private void LoadDataFromExcelFile()
        {
            using (var package = new ExcelPackage(new System.IO.FileInfo(Constants.filePath)))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets[0];
                DataTable dt = new DataTable();

                //creaza headerele pentru datatable pe baza excelului
                for (int columnIndex = 1; columnIndex <= ws.Dimension.End.Column - 5; columnIndex++)
                {
                    //MessageBox.Show(columnIndex.ToString());
                    DataColumn newColumn = dt.Columns.Add();
                    newColumn.ColumnName = ws.Cells[1, columnIndex].Text;
                }
                //populeaza datatabelul dt cu valorile din excel incepem cu randul 2 sa nu aducem headerele din nou
                int startRow = 2;
                for(int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];

                    if(rowNum == 2)
                    {
                        //check if we are in row 2 and put total consumption per day month and year in textBoxes
                        totalEnergieZi_TextBox.Text = ws.Cells["E2"].Text;
                        totalEnergieLuna_TextBox.Text = ws.Cells["F2"].Text;
                        totalEnergieAn_TextBox.Text = ws.Cells["G2"].Text;
                    }

                    DataRow row = dt.Rows.Add();
                    foreach(var cell in wsRow)
                    {
                       /* Console.WriteLine(cell);*/
                        int columnIndex = cell.Start.Column - 1;
                        if (columnIndex < dt.Columns.Count)
                        {
                          
                            row[columnIndex] = cell.Text;
                        } 
                    }
                }
                
                //bind dataTable to my datagridView
                    produse_table.DataSource = dt; 
            }
         }



        private void adaugaProdus_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)produse_table.DataSource;
            

            if (consumWati != null && currentProduct != null && oreUtilizare_TextBox2.Text != "")
            {
                ore_utilizare = oreUtilizare_TextBox2.Text;
                int dailyConsumption;
                double monthlyConsumption, yearlyConsumption;
                int consumWatiAsNumber, ore_utilizareAsNumber;

               // Console.WriteLine("valori " + consumWati + " " + currentProduct + " " + ore_utilizare);

                //conver from string to number
                int.TryParse(consumWati, out consumWatiAsNumber);
                int.TryParse(ore_utilizare, out ore_utilizareAsNumber);

                // Calculate consumption per day (kWh)
                double consumptionPerDay = consumWatiAsNumber * ore_utilizareAsNumber / 1000.0;

                // Display the result as a whole number or a double value
                 dailyConsumption = (int)consumptionPerDay; // Whole number
                 monthlyConsumption = consumptionPerDay * DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); // Monthly consumption
                 yearlyConsumption = consumptionPerDay * 365; // Yearly consumption

                // Console.WriteLine("rezultate " + dailyConsumption + " " + monthlyConsumption + " " + yearlyConsumption);
                totalConsumptionDay += dailyConsumption;
                totalConsumptionMonth += monthlyConsumption;
                totalConsumptionYear += yearlyConsumption;

                //store the new value in excel    
                storeDataInExcelFile(
                    currentProduct, dailyConsumption.ToString(),
                    monthlyConsumption.ToString(),
                    yearlyConsumption.ToString(),
                    totalConsumptionDay,
                    totalConsumptionMonth,
                    totalConsumptionYear);
                //we create data source table only if values has been written to excel 
                if (wasWrittenToExcel)
                {
                    //create new row in our dataTable
                    DataRow newRow = dt.NewRow();
                    newRow["Produs"] = currentProduct;
                    newRow["kWh/zi"] = dailyConsumption.ToString();
                    newRow["kWh/luna"] = monthlyConsumption.ToString();
                    newRow["kWh/an"] = yearlyConsumption.ToString();
                    dt.Rows.Add(newRow);


                    produse_table.DataSource = dt;
                    resetValues();

                    totalEnergieZi_TextBox.Text = totalConsumptionDay.ToString();
                    totalEnergieLuna_TextBox.Text = totalConsumptionMonth.ToString();
                    totalEnergieAn_TextBox.Text = totalConsumptionYear.ToString();

                }
            }
            else
            {
                MessageBox.Show("Unul sau mai multe campuri necompletate!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void selecteazaProdus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selecteazaProdus_comboBox.SelectedIndex != -1)
            {
                string pickedItem = selecteazaProdus_comboBox.SelectedItem.ToString();
                Product selectedProduct = products.Find(item => item.name == pickedItem);
                consumW_TextBox.Text = selectedProduct.powerConsumption.ToString();
                consumWati = consumW_TextBox.Text;
                currentProduct = pickedItem;
            }
            return;
        }

        private void resetValues()
        {
            selecteazaProdus_comboBox.SelectedIndex = -1;
            consumW_TextBox.Text = "";
            oreUtilizare_TextBox2.Clear();
        }

        private void reset_Btn_Click(object sender, EventArgs e)
        {
            resetValues();
        }
    }
}

