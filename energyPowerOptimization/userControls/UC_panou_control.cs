using System.Windows.Forms;
using OfficeOpenXml;

namespace energyPowerOptimization.userControls
{
    public partial class UC_panou_control : UserControl
    {
        public UC_panou_control()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            LoadDataFromExcelFile();
        }

        private void LoadDataFromExcelFile()
        {
            using (var package = new ExcelPackage(new System.IO.FileInfo(Constants.filePath)))
            {
                ExcelWorksheet ws = package.Workbook.Worksheets[0];

                products_chart.Series["consumInitialTotal"].CustomProperties = "PointWidth = 1";
                products_chart.Series["consumOptimizatCuPanouri"].CustomProperties = "PointWidth = 1";
                products_chart.Series["consumOptimizatCuEoliane"].CustomProperties = "PointWidth = 1";
                
                int startRow = 2;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];

                    if (rowNum == 2)
                    {
                        double consumInitialTotalNr, consumOptimizatPanouSolarNr, consumOptimizatEolianaNr;
                        //check if we are in row 2 and put total consumption per day month and year in textBoxes
                        string consumInitialTotal = ws.Cells["G2"].Text;
                        string consumOptimizatPanouSolar = ws.Cells["H2"].Text;
                        string consumOptimizatEoliana = ws.Cells["I2"].Text;
                        double.TryParse(consumInitialTotal, out consumInitialTotalNr);
                        double.TryParse(consumOptimizatPanouSolar, out consumOptimizatPanouSolarNr);
                        double.TryParse(consumOptimizatEoliana, out consumOptimizatEolianaNr);

                        products_chart.Series["consumInitialTotal"].Points.AddY(consumInitialTotal);
                        products_chart.Series["consumOptimizatCuPanouri"].Points.AddY(consumOptimizatPanouSolar);         
                       products_chart.Series["consumOptimizatCuEoliane"].Points.AddY(consumOptimizatEolianaNr);

                    }
                }
            }
        }


    }
}
