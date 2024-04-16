using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int State_Started = 2;
        public int engine_state;

        public void Start()
        {
            Console.Out.WriteLine( "Start" );
            engine_state = State_Started;
        }

        public void Stop()
        {
            Console.Out.WriteLine( "Stop" );
            engine_state = StateStopped;
        }

        public String GetState()
        {
            String state = null;

            if( engine_state == StateStopped)
            {
                state = "STOPPED";
            }
            else if( engine_state == State_Started)
            {
                state = "STARTED";
            }

            return state;
        }
    }
}
