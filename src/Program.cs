using DominandoEFCore.Data;
using DominandoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using ApplicationContext db = new ApplicationContext();

            db.Database.EnsureCreated();

            List<Pessoa> _pessoas = db.Pessoas.ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
