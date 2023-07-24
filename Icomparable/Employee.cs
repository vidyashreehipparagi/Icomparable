using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable
{
    public class Employee
    {
        public double sal { get; set; }
        public string name { get; set; }
        
    }
    public class SalComparison : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            //throw new NotImplementedException();
            if(x.sal < y.sal)
            {
                return -1;
            }
            else if(x.sal>y.sal)
            {
            return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
