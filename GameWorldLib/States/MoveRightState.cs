using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.States
{
    public class MoveRightState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'w': return new MoveUpState();
                case 's': return new MoveDownState();
                default: return new MoveRightState();


            }
        }

        public bool OutputFunction(char input, CreatureStateMachine snake)
        {
            snake.Move.X++;
            return true;
        }
    }
}
