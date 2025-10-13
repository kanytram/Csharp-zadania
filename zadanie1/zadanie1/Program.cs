using System;
class Program

{
    static void Main()
    {
        Console.Write("Podaj swój wiek: ");

        int wiek;

        while (true) {

            try
            {
                wiek = Convert.ToInt32(Console.ReadLine()); 
                break; 
            }

            catch (Exception wyjatek)
            {
                Console.WriteLine("Błędne dane, spróbuj jeszcze raz");
            }
        }

        string answer;

        while (true)
        {
            try
            {
                Console.WriteLine("Czy masz legitymację? Wpisz 'tak' lub 'nie'");
                answer = Console.ReadLine().ToUpper();

                if (answer == "TAK" || answer == "NIE")
                {
                    break;
                }
                throw new Exception();
            }

            catch (Exception wyjatek1)
            {
                Console.WriteLine("Błędne dane, spróbuj jeszcze raz");
            }

        }

        bool hasId = (answer == "TAK") ? true : false;

        bool wstep = (wiek >= 18 && hasId) ? true : false;

        if (wstep) Console.WriteLine("Wstęp dozwolony");

        else Console.WriteLine("Wstęp NIEdozwolony");
     }
}


