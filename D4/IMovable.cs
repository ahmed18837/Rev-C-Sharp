using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    public interface IMovable
    {
        void Move();

        // Explicit Implementation
        int GetSpeed()
        {
            return 10;
        }
    }
}
