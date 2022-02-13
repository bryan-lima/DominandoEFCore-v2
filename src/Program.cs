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

            db.Pessoas.Add(new Pessoa 
            {
                Nome = "Teste",
                Telefone = "11988887777"
            });

            db.SaveChanges();

            List<Pessoa> _pessoas = db.Pessoas.ToList();

            foreach (Pessoa pessoa in _pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}");
            }
        }
    }
}
