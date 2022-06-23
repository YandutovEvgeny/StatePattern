using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardStatePattern
{
    class ButtonMove
    {
        public Button Button { get; set; }
        public IButtonState ButtonState { get; set; }

        public ButtonMove(Button button)
        {
            Button = button;
            ButtonState = new RightMove();
        }

        public void Move()
        {
            ButtonState.Move(this);
        }
        public void NextState()
        {
            ButtonState.NextState(this);
        }
    }
}
