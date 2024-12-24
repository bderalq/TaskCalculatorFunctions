using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCalculatorFunctions.Models
{
    internal class Addition
    {
        public int Add (int x, int y)
        {
            return x + y;
        }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Add(double u, int y, int z)
        {
            return u + y + z;
        }
        public int Salary(int basic, int workhours, int hourrate)
        {
            return basic + (workhours * hourrate);    
        }
    }
}
