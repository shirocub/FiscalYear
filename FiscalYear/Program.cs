namespace FiscalYear
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int FiscalYear = 0;
            switch (DateTime.Now.Month)
            {
                case 1:
                case 2:
                case 3:
                    FiscalYear = DateTime.Now.Year - 1;
                    break;
                default:
                    FiscalYear = DateTime.Now.Year;
                    break;
            }

            Console.WriteLine(string.Format("今年度は{0}年度です。", FiscalYear));            
            Console.ReadKey();

        }
    }
}
