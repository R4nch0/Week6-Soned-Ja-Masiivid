using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees-ja perekonnanimed
            //programm kontrollib andmete pikkust 
            //programm kuvab kumb nendest on pikem, kas ees-või perekonnanimi

            Console.WriteLine("sisesta eesnimi: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("siesta perekonnanimi");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            if(firstNameLength > lastNameLength){
                Console.WriteLine("Teie eesnimi on pikem");
            }
            else if(lastNameLength > firstNameLength){

                Console.WriteLine("Teie perekonnanimi on pikem");
            }
            else
            {
                Console.WriteLine("Teie eesnimi ja perekonnanimi on sama pikad");
            }

        }
    }
}
