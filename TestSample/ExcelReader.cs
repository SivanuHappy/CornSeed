using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestSample
{
    public class ExcelReader
    {
        public List<TestCaseData> ReadExcelData(string Filepath)
        {
            List<TestCaseData> login = new List<TestCaseData>();
            var row = new List<String>();
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(Filepath);
            Excel.Worksheet sheet = excelWorkbook.Worksheets.Item[1];
            Excel.Range range = sheet.UsedRange;
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value.ToString() != null)
                        row.Add(range.Cells[i, j].Value.ToString());
                }
                login.Add(new TestCaseData(row.ToArray()));
                row.Clear();
            }
            excelWorkbook.Close(0);
            excelApp.Quit();
            return login;
        }

    }
}
