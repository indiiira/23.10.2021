using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_10_2021
{
    class Task
    {

        public Task(string name, string description, string destination)
        {
            Name = name;
            Description = description;
            Destination = destination;
        }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Destination { get; private set; }
        public static Task CreateTask()
        {
            Console.WriteLine("Введите имя задачи");
            string name = Console.ReadLine();
            Console.WriteLine("Введите описание");
            string description = Console.ReadLine();
            Console.WriteLine("Для кого эта задача?");
            string destination = Console.ReadLine();
            Console.WriteLine("Задача добавлена!");
            return new Task(name, description, destination);

        }
    }
}
