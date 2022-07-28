using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int columns = 3;
            int image = 52; 
            int rowsFull; 
            int imageRemain;

            rowsFull = image / columns;
            imageRemain = image % columns;

            Console.WriteLine("Можно будет вывести "+ rowsFull + " полностью заполненных рядов, " + imageRemain + " картинок будет сверх меры.");
        }
    }
}



