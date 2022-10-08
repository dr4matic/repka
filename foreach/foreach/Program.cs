using System;
using System.Collections;
using System.Collections.Generic;

namespace fooreach
{
    class Program
    {
        static void Main(string[] args)
        {

            var kek = new Infinity();
            foreach (int b in kek)
            {
                Console.WriteLine(b);
            }

        }
        
        class Infinity : IEnumerable<int>
        {
            

            public IEnumerator<int> GetEnumerator()
            {
                return new Prekol();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new Prekol();
            }
        }
        class Prekol : IEnumerator<int>
        {
            private int Meme = 1000;
            public int Current => Meme;

            object IEnumerator.Current => Meme;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
          //    if (Meme < 5)
          //    {
          //         Meme++;
         //           return true;
         //       }
                
                Meme = Meme-7;
                return true;
            }

            public void Reset()
            {
              
            }
        }
    }
}
