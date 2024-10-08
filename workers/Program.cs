﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace workers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Department> departments = new List<Department>();
            departments.Add(new Department("ОИТ"));
            departments.Add(new Department("ОБ"));
            List<Sektor> sektors = new List<Sektor>();
            sektors.Add(new Sektor("Engineers"));
            sektors.Add(new Sektor("Dev"));

            List<Employee> employers = new List<Employee>();
            //Bosses
            Boss boss = new Boss("Борис", null);
            employers.Add(boss);
            BossAssistant assistant = new BossAssistant("О Ильхам", departments[1], boss);
            employers.Add(assistant);
            //
            HeadOfDepartment headBuh = new HeadOfDepartment("Рашид", departments[1], boss);
            employers.Add(headBuh);
            MainPersonOfDepartment MainBuh = new MainPersonOfDepartment("Лукас", departments[1], headBuh);
            employers.Add(MainBuh);

            //OIT
            HeadOfDepartment headOIT = new HeadOfDepartment("Оркадий", departments[0], assistant);
            employers.Add(headOIT);
            MainPersonOfDepartment mainOIT = new MainPersonOfDepartment("Володя", departments[0], headOIT);
            employers.Add(mainOIT);

            //Developer
            HeadOfDevelopers bossDev = new HeadOfDevelopers("Сергей", departments[0], sektors[1], mainOIT);
            employers.Add(bossDev);
            MainDeveloper mainDev = new MainDeveloper("Ляйсан", departments[0], sektors[1], bossDev);
            employers.Add(mainDev);
            //Developer

            employers.Add(new Developer("Марат", departments[0], sektors[1], mainDev));
            employers.Add(new Developer("Антон", departments[0], sektors[1], mainDev));
            employers.Add(new Developer("Ильдар", departments[0], sektors[1], mainDev));
            employers.Add(new Developer("Дина", departments[0], sektors[1], mainDev));

            //Engineers
            HeadEngineer bossEng = new HeadEngineer("Ильшат", departments[0], sektors[0], mainOIT);
            employers.Add(bossEng);
            MainEngineer mainEng = new MainEngineer("Иваныч", departments[0], sektors[0], bossEng);
            employers.Add(mainEng);
            //Engineers
            employers.Add(new Engineer("Илья", departments[0], sektors[0], mainEng));
            employers.Add(new Engineer("Витя", departments[0], sektors[0], mainEng));
            employers.Add(new Engineer("Женя", departments[0], sektors[0], mainEng));

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите команду <task>, чтобы дать задачу; <exit> чтобы завершить программу");
                string input = Console.ReadLine().ToLower();

                if (Equals(input, "task"))
                {
                    Console.Write("кто даёт задачу? имя-->\t");
                    string nameFrom = Console.ReadLine();
                    Console.Write("Для кого эта задача? имя-->\t");
                    string nameTo = Console.ReadLine();
                    foreach (var employerFrom in employers)
                    {

                        if (nameFrom.Equals(employerFrom.name))
                        {
                            Console.WriteLine("мы нашли главного, ищем выполняющего");
                           
                            foreach (var employerTo in employers)
                            {
                                if (nameTo.Equals(employerTo.name))
                                {
                                    Console.WriteLine("работник найден!");
                                    employerFrom.GiveTask(employerTo, new Task("отчет"));

                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }

                }
                else if (Equals(input, "exit"))
                {
                    flag = false;
                }


            }
        }
    }
}
