using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curkemur
{
    class Kalkulator
    {
        public decimal Calculate(string expresion)
        {
            decimal chisla = 0;
            var numbers = ParsString(expresion);
            for (var i=0;i<numbers.Length;i++)
            {
                 chisla = chisla + numbers[i];
            }
            return chisla;
        }
        private decimal[] ParsString(string expresion)
        {   var kretin = expresion.Split('+');
            var result = new List<decimal>(kretin.Length);
            for (var i=0;i<kretin.Length;i++)
            {
                if (result.Contains('-'))
                {

                }
                else 
                {

                }
                var kek = decimal.Parse(kretin[i]);
                result.Add(kek);
            }
            return result.ToArray();
        }
       
    }
}
