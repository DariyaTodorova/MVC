using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyfistMVC.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Percent { get; set; }

  

        public double TipSum { get; set; }

        public double TotalSum { get; set; }
        public void Input()
        {
            Console.Write("Vuvedete sumata na smetkite: ");
            double sum = double.Parse(Console.ReadLine());
            this.Amount = sum;


            Console.Write("Vuvedete procenta na kelnera: ");
            double percent = double.Parse(Console.ReadLine());
            this.Percent = percent;

            
        }
        public void Output()
        {
            Console.WriteLine($"Bakshisha za servitora e: {this.TipSum} lv.");
            Console.WriteLine($"Sumata za plashtane e: {this.TotalSum} lv.");
        }
    }
}
