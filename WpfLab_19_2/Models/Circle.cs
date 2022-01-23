using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab_19_2.Models
{
    class Circle
    {
        public static double Length(double a)
        {
            double circumference=a * 2 * Math.PI;
            return circumference;
        }
    }
}
