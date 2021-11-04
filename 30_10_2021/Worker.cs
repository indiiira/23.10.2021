using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_10_2021
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
        private int warnings = 0;
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
                if (worker.Name == name && !(worker is SystemWorker) && !(worker is Developer))
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
                isCanGiveTask = false;
                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i].Head == null)
                    {
                        continue;
                    }
                    else if (workers[i].Name == name && workers[i].Head.GetType() == typeBossGivingTask)
                    {
                        isCanGiveTask = true;
                        if (name.Equals("Дина"))
                        {
                            Console.WriteLine("Задача может быть передана!");
                            Console.WriteLine("Дина Латыпова сверхчеловек,поэтому она может решить неограниченное кол-во задач!");
                            Console.WriteLine("Давайте добавим в ее репертуар еще одну!");
                            Console.WriteLine("Согласен ли работник на задание? да/нет");
                            string input = Console.ReadLine().ToLower();
                            if (!input.Equals("нет"))
                            {
                                workers[i].tasks.Add(Task.CreateTask());
                                isCanGiveTask = true;
                            }
                            else
                            {
                                workers[i].warnings++;
                            }
                        }
                        else
                        {
                            if (workers[i].tasks.Count < 1)
                            {
                                Console.WriteLine("Задача может быть передана!");
                                Console.WriteLine("Согласен ли работник на задание? да/нет");
                                string input = Console.ReadLine().ToLower();
                                if (!input.Equals("нет"))
                                {
                                    workers[i].tasks.Add(Task.CreateTask());
                                }
                                else
                                {
                                    workers[i].warnings++;
                                }
                            }

                        }
                        if (workers[i].warnings >= 3)
                        {
                            Console.WriteLine($"Работник {workers[i].Name} получил 3 или более предупреждения!");
                        }
                    }

                }
            }
            if (!isCanGiveTask)
            {
                Console.WriteLine("Нельзя передать задачу этому работнику!");
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
        public static void SwapTask(List<Worker> workers)
        {
            Console.WriteLine("Введите имя работника,кто хочет передать задачу?");
            string name = Console.ReadLine();
            bool swaped = false;
            foreach (var worker in workers)
            {
                if (worker.Name.Equals(name) && !(worker is Developer) && !(worker is SystemWorker))
                {
                    Console.WriteLine("Данный работник был найден!");
                    Type type = worker.GetType();
                    Console.WriteLine("Кому вы хотите передать задачу?");
                    string nameWorker = Console.ReadLine();
                    foreach (var workerWhoIsSwaped in workers)
                    {
                        if (worker.Head == null)
                        {
                            continue;
                        }
                        if (workerWhoIsSwaped.Name.Equals(nameWorker) && type == workerWhoIsSwaped.Head.GetType() && workerWhoIsSwaped.Name != worker.Name)
                        {
                            Console.WriteLine("Задача может быть передана!");
                            if (worker.tasks.Count != 0)
                            {
                                var SwapTask = worker.tasks.Last();
                                worker.tasks.Remove(worker.tasks.Last());
                                workerWhoIsSwaped.tasks.Add(SwapTask);
                                swaped = true;
                                Console.WriteLine($"Задача была передана от {worker.Name} к {workerWhoIsSwaped.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"У {worker.Name} и так нет задач!");
                            }
                        }
                    }
                }
            }
            if (!swaped)
            {
                Console.WriteLine("Данный работник не может дать задачу,по каким-то причинам!");
            }

        }
    }
}