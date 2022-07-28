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
            int columns = 3; // Количество столбцов
            int image = 52; // Количество картинок
            int rows; // Количество рядов
            int imageRemain; // Кол-во изображений сверх меры

            rows = image / columns;
            imageRemain = image % columns;

            Console.WriteLine("Можно будет вывести "+ rows+ " полностью заполненных рядов, " + imageRemain + " картинок будет сверх меры.");

        }
    }
}



