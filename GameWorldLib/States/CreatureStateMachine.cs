using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.States
{
    public class CreatureStateMachine
    {
        public Move Move { get; set; }
        public IState<char, bool> State { get; set; }

        public CreatureStateMachine()
        {
            State = new MoveUpState();
            Move = new Move(10, 10);
        }

        public void Update(char input)
        {
            State = State.NextStateFunction(input);
            State.OutputFunction(input, this);

        }
    }
}
