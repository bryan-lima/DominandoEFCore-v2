using DominandoEFCore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using ApplicationContext db = new ApplicationContext();
            //db.Database.Migrate();

            IEnumerable<string> _migracoes = db.Database.GetPendingMigrations();
            
            foreach (string migracao in _migracoes)
            {
                Console.WriteLine(migracao);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
