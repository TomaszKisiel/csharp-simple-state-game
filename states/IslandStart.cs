using System;

namespace states
{
    class IslandStart : State
    {
        public override void Question() {
            Console.WriteLine( "Budzisz się na plaży na bezludnej wyspie, przed Tobą rozciąga się wielki las.. co robisz?" );
        }

        public override void Answers() {
            Console.WriteLine("\t1. Wchodze do lasu");
            Console.WriteLine("\t2. Zostaje na plaży");
            Console.WriteLine();
        }

        public override void Handle() {
            string c = Console.ReadLine();
            if ( c == "1" ) {
                Game.ChangeState( new DeepForest() );
            } else if ( c == "2" ) {
                Console.WriteLine("Przychodzi kanibal i Cię zjada. PRZEGRAŁEŚ");
                Environment.Exit(0);
            }
        }
    }
}
