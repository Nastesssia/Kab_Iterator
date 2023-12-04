using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kab_Iterator
{
    public class AlphabetLibrary : IEnumerable<char>
    {
        private char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public IEnumerator<char> GetEnumerator()
        {
            return ((IEnumerable<char>)alphabet).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main()
        {
            AlphabetLibrary library = new AlphabetLibrary();

            //foreach для перебора элементов коллекции через итератор
            foreach (char letter in library)
            {
                Console.WriteLine(letter); 
            }
            Console.ReadKey();
        }
        
    }

}
