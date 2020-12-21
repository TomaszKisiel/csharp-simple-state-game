using System;

namespace states
{
    class CannibalsVillage : State
    {
        public override void Question() {
            Console.WriteLine( "Ku swojej wielkiej uciesze dochodzisz do jakiejś małej wioski w środku lasu.. co robisz?" );
        }

        public override void Answers() {
            Console.WriteLine("\t1. Podchodzę przywitać się z mieszkańcami");
            Console.WriteLine("\t2. Uciekam");
            Console.WriteLine();
        }

        public override void Handle() {
            string c = Console.ReadLine();
            if ( c == "1" ) {
                Console.WriteLine("Mieszkańcy wioski to kanibale.. witają Cię z wielką radością po czym zjadają. PRZEGRAŁEŚ");
                Environment.Exit(0);
            } else if ( c == "2" ) {
                Console.WriteLine("Mieszkańcy wioski to kanibale.. zaczynają Cię gonić i zjadają. PRZEGRAŁEŚ");
                Environment.Exit(0);
            }
        }
    }
}
