using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.States
{
    public class MoveUpState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'a': return new MoveLeftState();
                case 'd': return new MoveRightState();
                default: return new MoveUpState();


            }
        }

        public bool OutputFunction(char input, CreatureStateMachine snake)
        {
            snake.Move.Y--;
            return true;
        }
    }
}
