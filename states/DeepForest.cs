using System;

namespace states
{
    class DeepForest : State
    {
        public override void Question() {
            Console.WriteLine( "Las zaczyna robić się coraz gęstszy, ale dostrzegasz coś na pozór ścieżki.. co robisz?" );
        }

        public override void Answers() {
            Console.WriteLine("\t1. Idę dalej gęstwiną");
            Console.WriteLine("\t2. Wchodzę na ścieżkę");
            Console.WriteLine("\t3. Robię sobie przerwę");
            Console.WriteLine();
        }

        public override void Handle() {
            string c = Console.ReadLine();
            if ( c == "1" ) {
                Game.ChangeState( new CannibalsVillage() );
            } else if ( c == "2" ) {
                Console.WriteLine("Kanibal zagradza Cię drogę i Cię zjada. PRZEGRAŁEŚ");
                Environment.Exit(0);
            } else if ( c == "3" ) {
                Console.WriteLine("Zabawny jesteś.. nie ma czegoś takiego jak przerwa na AGH.. PRZEGRAŁEŚ!!!");
                Environment.Exit(0);
            }
        }
    }
}
