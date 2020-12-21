using System;

namespace states
{
    abstract class State
    {

        public abstract void Question();
        public abstract void Answers();
        public abstract void Handle();
    }
}
