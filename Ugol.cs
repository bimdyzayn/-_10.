using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_10
{
    class Ugol
    {
        private int gradusf=5;
        private int minf=4;
        private int secf=3;


        public int gradus 
        {
            get 
            {
                return gradusf;
            }
            set 
            {

                if (value.GetType() == typeof(int))
                    gradusf = value;
               
                else
                    gradusf = 0;
            }
        }
  

        public int min
        {
            get
            {
                return minf;
            }
            set 
            {

                if (value.GetType() == typeof(int))
                    minf = value;

                else
                    minf = 0;
            }
        }
        public int sec
        {
            get
            {
                return secf;
            }
            set 
            {

                if (value.GetType() == typeof(int))
                    secf = value;

                else
                    secf = 0;
            }
        }
        public double ToRadians()
        {

  
            return gradus * Math.PI / 180; 
        }
    }
}
