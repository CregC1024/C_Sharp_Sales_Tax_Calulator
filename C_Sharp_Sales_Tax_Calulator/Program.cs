
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cce_console
{
    public class TaxCalculator
    {
        private static decimal _itemPrice;
        private static decimal _percentTaxRate;
        private static decimal _totalPrice;

        public TaxCalculator(string inputItemPrice, string inputTaxRate)
        {
            _itemPrice = Decimal.Parse(inputItemPrice);
            _percentTaxRate = Decimal.Parse(inputTaxRate) / 100;
            
        }

        public void CalculateTotalPrice()
        {
            _totalPrice = _itemPrice + (_itemPrice * _percentTaxRate);
        }

        public void GetTotalMsg()
        {
            Console.WriteLine("The subtotal is {0:C} and the total price is {1:C} at the tax rate of {2:p0}", _itemPrice, _totalPrice, _percentTaxRate);
            Console.WriteLine("The total price is:$" + _totalPrice );
            Console.WriteLine("The tax rate is:$" + _percentTaxRate);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Price of item: ");
            string itemPrice = Console.ReadLine();
            Console.Write("Enter tax rate (in percentage): ");
            string taxRate = Console.ReadLine();
            TaxCalculator myTaxCalculator = new TaxCalculator(itemPrice, taxRate);
            myTaxCalculator.CalculateTotalPrice();
            myTaxCalculator.GetTotalMsg();
            Console.ReadKey();
        }
    }
}
