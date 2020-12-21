using System;

namespace states
{
    class Game
    {
        private static State state = new IslandStart();

        public void Play()
        {
            while( true ) {
                Console.Clear();
                state.Question();
                state.Answers();
                state.Handle();
            }
        }

        public static void ChangeState( State next ) {
            state = next;
        }
    }
}
