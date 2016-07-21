using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(3, 5, '#');
            p2.Draw();

            HorisontalLine line = new HorisontalLine(4, 15, 13, '*');
            line.Draw();
            VerticalLine column = new VerticalLine(5, 13, 17, '*');
            column.DrawV();

            Console.ReadLine();
        }


    }
}
