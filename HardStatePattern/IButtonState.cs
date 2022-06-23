using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStatePattern
{
    interface IButtonState
    {
        void NextState(ButtonMove buttonMove);
        void Move(ButtonMove buttonMove);
    }
}
