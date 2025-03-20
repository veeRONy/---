using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lr4_1
{
    public  interface IMovable
    {
        void Move(int dx, int dy);

        bool CanMoveX(int dx, int width);

        bool CanMoveY(int dy, int height);
    }
}
