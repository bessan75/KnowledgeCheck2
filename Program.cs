using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2B
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var catFood = new CatFood();

                Console.WriteLine("Enter the value for ");
                catFood.WeightPounds = Convert.ToDouble(Console.ReadLine());
                catFood.KittenFood = Convert.ToBoolean(Console.ReadLine());
                catFood.Name = Console.ReadLine();
                catFood.Description = Console.ReadLine();
                catFood.Price = Convert.ToDouble(Console.ReadLine());
                catFood.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"WeightPounds: {catFood.WeightPounds}, KittenFood: {catFood.KittenFood}, Name: {catFood.Name}," +
                    $"Description:{catFood.Description}, Price: {catFood.Price}, Quantity: {catFood.Quantity}");

                recordList.Add(catFood);
            }

            // Print out the list of records using Console.WriteLine()
        }
    }
}
