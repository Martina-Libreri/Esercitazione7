using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eccezioni");
            //ExceptionDatabase.Run();

            try
            {
                Utente utente = new Utente(null);
                utente.Controllo(utente);
            }
            catch(ExceptionCustom e)
            {
                Console.WriteLine(e.Message);
                if (e.InnerException != null)
                    Console.WriteLine("Inner exception: {0}", e.InnerException);
            }

        }
    }
}
