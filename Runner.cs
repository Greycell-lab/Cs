using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run
{
    class Runner
    {
        public int x=0;
        public int y=0;
               
        public Runner(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int RunX()
        {
            x++;
            return x;
        }
        public int RunY()
        {
            y++;
            return y;
        }
        public int BackX()
        {
            x--;
            return x;
        }
        public int BackY()
        {
            y--;
            return y;
        }
        public void RunR()
        {
            x = 0;
            y = 0;
        }
    }
}
