using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace TestEFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (var ctx = new Contexto())
            //{
            //    ctx.Pessoas.Add(new Pessoa() { Id = Guid.NewGuid(), Idade = 32, Nome = "Fabio S Gonçalves" });
            //    ctx.SaveChanges();
            //}

            //Console.WriteLine("Lista");

            //using (var ctx = new Contexto())
            //{
            //    var lista = ctx.Pessoas.ToList();
            //    foreach (var item in lista)
            //    {
            //        Console.WriteLine($"Pessoa: {JsonConvert.SerializeObject(item)}");
            //    }

            //}
            //Console.WriteLine("Fim");


            //Im memory

            var options = new DbContextOptionsBuilder<ContextoMemory>()
               .UseInMemoryDatabase(databaseName: "PessoaMemoria")
               .Options;

            using (var ctx = new ContextoMemory(options))
            {
                ctx.Pessoas.Add(new Pessoa() { Id = Guid.NewGuid(), Idade = 32, Nome = "Fabio S Gonçalves" });
                ctx.SaveChanges();
            }

            Console.WriteLine("Lista");

            using (var ctx = new ContextoMemory(options))
            {
                var lista = ctx.Pessoas.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"Pessoa: {JsonConvert.SerializeObject(item)}");
                }

            }
            Console.WriteLine("Fim");
            Console.ReadKey();

        }
    }
}
