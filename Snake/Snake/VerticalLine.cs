using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList = new List<Point>();
        public VerticalLine(int x, int yTop, int yBottom, char sym)
        {
            
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void DrawV ()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
