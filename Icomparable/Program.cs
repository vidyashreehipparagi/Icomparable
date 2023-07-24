using Icomparable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Comparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product Pen = new Product("Pen", 20);
            //Product Book = new Product("Book", 30);

            //int result = Pen.CompareTo(Book);
            //if (result > 0)
            //{
            //    Console.WriteLine("Pen has greater price than book");
            //}
            //else if (result < 0)
            //{
            //    Console.WriteLine("Book has more price than pen");
            //}
            //else
            //{
            //    Console.WriteLine("Both pen and Book are having same price");
            //}

            Employee Akshata= new Employee { sal=50000,name="Akshata"};
            Employee Anjali = new Employee { sal = 52000, name = "Anjali" };

            SalComparison obj=new SalComparison();
            int result1= obj.Compare(Akshata, Anjali);
            if (result1< 0)
            {
                Console.WriteLine("Anjali has more Salary than Akshata");
            }
            else if(result1 >0)
            {
                Console.WriteLine("Akshata has more sal than Anjali");
            }
            else
            {
                Console.WriteLine("Both are having same sal");
            }
        }
        }
    }

