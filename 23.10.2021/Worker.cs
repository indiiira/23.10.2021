using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._2021
{
    abstract class Worker
    {
        public Worker()
        {

        }
        public Worker(string name, ref int lastID)
        {
            lastID++;
            Name = name;
            id = lastID;
        }
        public Worker(string name, ref int lastID, Worker head)
        {
            lastID++;
            Name = name;
            id = lastID;
            Head = head;
        }
        public Worker(string name, string surname, Worker head, ref int lastID)
        {
            lastID++;
            Name = name;
            Surname = surname;
            id = lastID;
            Head = head;
        }
        public string Post { get; protected set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int id { get; private set; }

        public Worker Head { get; private set; }
        private List<Task> tasks = new List<Task>();
        public static void GiveTask(List<Worker> workers)
        {
            Console.WriteLine("Кто дает задачу?//введите имя работника");
            string name = Console.ReadLine();
            Worker worker1 = new Developer();
            bool isCanGiveTask = false;
            Type typeBossGivingTask = worker1.GetType();
            foreach (var worker in workers)
            {
                if (worker.Name == name && !(worker is SystemWorker) && !(worker is AssistantDeveloper))
                {
                    isCanGiveTask = true;
                    typeBossGivingTask = worker.GetType();
                    Console.WriteLine("Данный работник был найден");
                    Console.WriteLine("Его данные");
                    worker.PrintInfo();
                    Console.WriteLine("Данный работник может дать задачу!");
                }
            }
            if (!isCanGiveTask)
            {
                Console.WriteLine("Данный работник не может дать задачу");
            }
            else
            {
                Console.WriteLine("Введите имя работника кому вы хотите дать задачу");
                name = Console.ReadLine();
                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i].Head == null)
                    {
                        continue;
                    }
                    if (workers[i].Name == name && workers[i].Head.GetType() == typeBossGivingTask)
                    {

                        if (name.Equals("Дина"))
                        {
                            Console.WriteLine("Задача может быть передана!");
                            Console.WriteLine("Дина Латыпова сверхчеловек,поэтому она может решить неограниченное кол-во задач!");
                            Console.WriteLine("Давайте добавим в ее репертуар еще одну!");
                            workers[i].tasks.Add(Task.CreateTask());
                        }
                        else
                        {
                            if (workers[i].tasks.Count < 1)
                            {
                                Console.WriteLine("Задача может быть передана!");
                                workers[i].tasks.Add(Task.CreateTask());
                            }
                        }
                    }
                }
            }
        }
        public virtual void PrintInfo()
        {
            if (Surname == null)
            {
                Surname = "У работника нет фамилии";
            }
            if (Head == null)
            {
                Console.WriteLine("Он босс!");
            }
            Console.WriteLine($"Имя работника {Name}, фамилия работника {Surname}, id работника {id}");
        }

    }
}

