using System.Reflection;
using Microsoft.Office.Interop.Excel;
using SmoothData.Class;
using SmoothData.Utils;

namespace SmoothData
{
    class Program
    {
        static void Main(string[] arags)
        {
            ExcelClass obj = new ExcelClass()
            {
                Current = "123",
                Voltage = "eqweqjlk"
            };
            var test = ReflexUtil<CountAttribute, ExcelClass>.ReflexAttrIsNeed(obj);


            Application excelApp = new Application();
            excelApp.Visible = false;
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet ws = (Worksheet)workbook.Worksheets[1];
            ws.Name = "sheet2";
            Worksheet ws1 = workbook.Worksheets.Add(After: ws);
            ws1.Name = "sheet3";
            int i = 0;
            foreach (var item in test)
            {
                ws.Cells[i + 1, 1] = item.Key;
                i++;
            }

            string filePath = @"C:\Users\cx\Desktop\test.xlsx";
            workbook.SaveAs(filePath);
            workbook.Close();
            excelApp.Quit();
        }

        private static void CreateData(Worksheet ws)
        {
        }
    }
}