using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStatePattern
{
    class BottomMove : IButtonState
    {
        public void Move(ButtonMove buttonMove)
        {
            buttonMove.Button.Top += 5;
        }

        public void NextState(ButtonMove buttonMove)
        {
            buttonMove.ButtonState = new LeftMove();
        }
    }
}