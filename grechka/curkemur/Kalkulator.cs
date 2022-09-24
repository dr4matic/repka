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
            /*for (var i=0;i<numbers.Count;i++)
            {
                 chisla = chisla + numbers[i];
            }*/
            foreach(var seledka in numbers)
            {
                chisla = chisla + seledka;
            }
            return chisla;
        }
        private List<decimal> ParsString(string expresion)
        {   var kretin = expresion.Split('+');
            var result = new List<decimal>(kretin.Length);
            for (var i=0;i<kretin.Length;i++)
            {
                if (kretin[i].Contains('-'))
                {
                    var pepe = ParsStringMinus(kretin[i]);
                    result.AddRange(pepe);
                }
                else 
                {
                var kek = decimal.Parse(kretin[i]);
                result.Add(kek);
                }
                
            }
            return result;
        }
        private List<decimal> ParsStringMinus(string expresion)
        {
            var kretin = expresion.Split('-');
            var result = new List<decimal>(kretin.Length);
            var min = 1;
            for (var i = 0; i < kretin.Length; i++)
            {
                if (kretin[i].Length == 0)
                {
                    min = -1;
                    continue;
                }
                var kek = decimal.Parse(kretin[i])*min;
                result.Add(kek);
                min = -1;
            }
            return result;
        }

    }
}
