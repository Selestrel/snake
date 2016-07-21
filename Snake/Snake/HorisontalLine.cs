using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorisontalLine
    {
        List<Point> pList;

        public HorisontalLine(int xLeft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x<=xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw ()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
