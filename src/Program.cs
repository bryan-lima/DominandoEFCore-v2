using DominandoEFCore.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace DominandoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using ApplicationContext db = new ApplicationContext();
            db.Database.Migrate();

            Console.WriteLine("Hello World!");
        }
    }
}
