using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSample
{
    public class TestCaseRead
    {
        static string FilePath = @"C:\Users\anush\source\repos\TestSample\TestSample\TestData\TestData.xlsx";
        public static IEnumerable<TestCaseData> ReadExcel
        {
            get
            {
                List<TestCaseData> TestCaseDataList = new ExcelReader().ReadExcelData(FilePath);
                Console.Write(TestCaseDataList);
                if (TestCaseDataList != null)
                    foreach (TestCaseData TestCaseData in TestCaseDataList)
                        yield return TestCaseData;
            }
        }
    }
}
