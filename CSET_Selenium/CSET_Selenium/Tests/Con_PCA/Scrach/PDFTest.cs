using CSET_Selenium.DriverConfiguration;
using NUnit.Framework;
using OpenQA.Selenium;
using iText;
using System.Text;
using System;

namespace CSET_Selenium.Tests.Con_PCA.Scrach
{
    [TestFixture]
    public class PDFContentTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void PDFFileTest()
        {
            

           /* PdfReader.unethicalreading = true;
            PdfReader reader = new PdfReader("C:\\tmp\\CISA_PCA_CYCLE_report.pdf");
            //String pwd = "Y&nI%U4$^<wxGiF{.6!(";
            //PdfReader reader = new PdfReader("C:\\tmp\\ConPCA.pdf", new byte[pwd.Length]);

            StringBuilder text = new StringBuilder();

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }

            Console.WriteLine(text.ToString());*/

        }
    }
}
