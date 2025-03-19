using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    abstract class CShape
    {
        public abstract void Draw(Graphics g);
        public abstract CShape GetRealObject();
        
    }
}
