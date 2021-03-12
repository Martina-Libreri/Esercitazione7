using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class ExceptionCustom : Exception 
    {
        //Generare eccezione utente non trovato
        public ExceptionCustom(string message) : base(message) { }
        
        public ExceptionCustom(string message, Exception innerException) : base(message, innerException) { }
    }

    public class Utente
    {
        string Nome { get; set; }

        public Utente(string nome) { Nome = nome; }

        public void Controllo(Utente utente)
        {

            _ = utente.Nome ?? throw new ExceptionCustom("L'utente non è nel database");
        }
    }

    
}
