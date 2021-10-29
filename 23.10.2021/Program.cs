using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new List<Worker>();
            int lastID = 0;
            ///BOSS
            workers.Add(new Boss("Борис", ref lastID));
            ///BOSS

            ///AssistantBoss
            workers.Add(new BossAssistant("О Ильхам", ref lastID, workers[lastID - 1]));
            ///AssistantBoss

            ///MainDeveloper
            workers.Add(new MainDeveloper("Сергей", ref lastID, workers[lastID - 1]));
            ///MainDeveloper

            ///MainSystemWorker
            workers.Add(new MainSystemWorker("Ильшат", ref lastID, workers[lastID - 2]));
            ///MainSystemWorker


            ///AssistantSystemWorker
            workers.Add(new AssistantSystemWorker("Иваныч", ref lastID, workers[lastID - 1]));
            ///AssistantSystemWorker

            ///AssistantDeveloper
            workers.Add(new AssistantDeveloper("Ляйсан", ref lastID, workers[lastID - 3]));
            ///AssistantDeveloper

            //Developers
            workers.Add(new Developer("Марат", ref lastID, workers[lastID - 1]));
            workers.Add(new Developer("Антон", ref lastID, workers[lastID - 2]));
            workers.Add(new Developer("Ильдар", ref lastID, workers[lastID - 3]));
            workers.Add(new Developer("Дина", ref lastID, workers[lastID - 4]));
            //Developers

            //SystemWorkers
            workers.Add(new SystemWorker("Илья", ref lastID, workers[lastID - 6]));
            workers.Add(new SystemWorker("Витя", ref lastID, workers[lastID - 7]));
            workers.Add(new SystemWorker("Женя", ref lastID, workers[lastID - 8]));
            ///SystemWorkers

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команду <Задача>, чтобы дать задачу; <Выйти> чтобы завершить программу");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "задача":
                        Worker.GiveTask(workers);
                        break;
                    case "выйти":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Задачи на сегодня завершены,время отдыхать!");







        }
    }
    }

