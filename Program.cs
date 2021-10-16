using System;
using Menghi.Massimo._5H.PrimoEF.Models;

namespace Menghi.Massimo._5H.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello db-World!");

            // Apro il db
            DbPersone db = new();
            for(int i = 0; i < 1000; i++)
            {
                db.Persone.Add(new Persona{Nome = "Massimo", Cognome = "Menghi", EMail = "menghi.massimo@gmail.com"});
                db.SaveChanges();
            }
        }
    }
}
