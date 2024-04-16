using System;

namespace Exercise1
{
    class Engine
    {
        private const int State_Stopped = 1;
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
            engine_state = State_Stopped;
        }

        public string GetState()
        {
            string state = null;

            if (engine_state == State_Stopped)
                state = "STOPPED";

            else 
                state = "STARTED";

            return state;
        }
    }
}
