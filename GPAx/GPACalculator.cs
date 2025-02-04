using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAx
{
    internal class GPACalculator
    {
        private double gpa_sum = 0;
        private int n = 0;
        private double min;
        private double max;

        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;
            if (gpa <= min)
            {
                min = gpa;
            }
            else if (gpa >= max)
            {
                max = gpa;
                if (min == 0)
                {
                    min = gpa;
                }
            }
        }

        public double getGPAX()
        {
            return this.gpa_sum / this.n;
        }

        public double getMinGPA()
        {
            return this.min;
        }

        public double getMaxGPA()
        {
            return this.max;
        }
    }
}