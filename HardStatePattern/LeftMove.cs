using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStatePattern
{
    class LeftMove : IButtonState
    {
        public void Move(ButtonMove buttonMove)
        {
            buttonMove.Button.Left -= 5;
        }

        public void NextState(ButtonMove buttonMove)
        {
            buttonMove.ButtonState = new TopMove();
        }
    }
}
