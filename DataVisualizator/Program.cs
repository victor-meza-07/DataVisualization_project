using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataVisualizator.Data.local_models.BST;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataVisualizator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
            
                });









        private static void BST() 
        {
            BinaryTree tree = new BinaryTree();
            bool run = true;
            while (run == true) 
            {
                Console.WriteLine("1. Assign | 2. Search");
                string a = Console.ReadLine();
                if (a == "1") { BstAdd(tree); }
                else if (a == "2") { BstSearch(tree); }
                else { }
            }
        }
        private static void BstAdd(BinaryTree tree) 
        {
            Node node = new Node();
            Console.WriteLine("Value");
            node.Value = Int32.Parse(Console.ReadLine());
            tree.Add(node);
        }
        private static void BstSearch(BinaryTree tree) 
        {
            
            Console.WriteLine("What value should we search for?");
            int val = Int32.Parse(Console.ReadLine());
            Node result = tree.Search(val);
            Console.WriteLine("We found");
            int? rightVal = 0;
            int? leftVal = 0;
            if (result.RightChild != null) { rightVal = result.RightChild.Value; }
            if (result.LeftChild != null) { leftVal = result.LeftChild.Value; }
            Console.WriteLine($"V: {result.Value} | Left Child: {leftVal} | Right Child: {rightVal} | Generation {result.Generation} ");
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }
    }
}
