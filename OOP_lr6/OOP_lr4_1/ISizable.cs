using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    public interface ISizable
    {
        void ChangeSize(int da);
        bool CanChangeSize(int da, int width, int height);
    }
}
