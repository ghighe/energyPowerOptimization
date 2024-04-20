using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using OfficeOpenXml;

namespace energyPowerOptimization.userControls
{
    public partial class UC_optimizareConsum : UserControl
    {

        private readonly string filePath = "C:\\Users\\GHIGHE-I5\\Desktop\\energy_optimization.xlsx";
        public UC_optimizareConsum()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            init();
            getTotalConsumptionfromExcel();
        }

        private void init()
        {
            panouOptimizare_btn.Enabled = false;
            optimizareBaterie_Button1.Enabled = false;
            nrPanouri_TextBox.Enabled = false;
            nrBaterii_TextBox1.Enabled = false;
        }

        private void getTotalConsumptionfromExcel()
        {
            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets[0];

                int startRow = 2;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    if (rowNum == 2)
                    {
                        //check if we are in row 2 and put total consumption per day month and year in text
                        consumInitial_TextBox.Text = ws.Cells["G2"].Text;
                        break;
                    }

                }
            }
        }

        private void optimizare_cu_Panou_btn_Click(object sender, EventArgs e)
        {
            if(nrPanouri_TextBox.Text != "")
            {
                startProgressBar(solarPanel_ProgressBar1);
                int nrPanouri;
                int.TryParse(nrPanouri_TextBox.Text, out nrPanouri);
                SolarPanel sp = new SolarPanel(nrPanouri, 400, 5);
                double estimatedOutputKWhPerDay = sp.calculateEstimatedOutputKWh();
                double estimatedOutputKWhPerYear = estimatedOutputKWhPerDay * 365;
                Console.WriteLine($"Estimated output for {nrPanouri.ToString()} panel(s) of 400W in one year: {estimatedOutputKWhPerYear} kWh");

            }
            else {
                MessageBox.Show("Numar de panouri nespecificat!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
  
            }
            
        }

        private void toggleButtons(Guna2CustomRadioButton radioButton, Guna2Button buttonToEnable, Guna2Button buttonToDisable)
        {
            if (radioButton.Checked)
            {
                buttonToEnable.Enabled = true;
                buttonToDisable.Enabled = false;
  
            }
        }

        private void startProgressBar(Guna2ProgressBar progressBar) 
        {
            progressBar.Visible = true;
            int increment = progressBar.Maximum / 100;

            progressBar.Value = 0;


            for (int i = 1; i <= 100; i++)
            {
                progressBar.Value = i * increment;
                progressBar.Text = i + "%";
                progressBar.Refresh();
                System.Threading.Thread.Sleep(50);
            }
        }


        private void solarPanel_RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nrPanouri_TextBox.Enabled = true;
            nrBaterii_TextBox1.Enabled = false;
            toggleButtons(solarPanel_RadioButton1, panouOptimizare_btn, optimizareBaterie_Button1);
        } 


        private void battery_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nrBaterii_TextBox1.Enabled = true;
            nrPanouri_TextBox.Enabled = false;
            toggleButtons(battery_RadioButton2, optimizareBaterie_Button1, panouOptimizare_btn);
        }

        private void optimizareBaterie_Button1_Click(object sender, EventArgs e)
        {
            nrPanouri_TextBox.Enabled = false;
            startProgressBar(battery_ProgressBar1);
   
        }
    }
}
