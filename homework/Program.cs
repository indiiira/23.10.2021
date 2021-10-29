using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace homework
{

    enum AccountType
    {
        corrent,
        saving
    }

    public class Bank
    {
        private static Guid Identificator;
        private AccountType Type;
        private decimal valueOfMoney;

        public void FillSaving(decimal newValue)
        {
            Type = AccountType.saving;

            Identificator = Guid.NewGuid();
            valueOfMoney = newValue;

        }
        public void FillCorrent(decimal newValue)
        {
            Type = AccountType.corrent;

            Identificator = Guid.NewGuid();
            valueOfMoney = newValue;
        }
        public void WriteTheDataOfCorrentType()
        {
            Console.WriteLine($"Type:{Type} \n ID : {Identificator} \n Value of money : {valueOfMoney}");
        }
        public void WriteTheDataOfSavingType()
        {
            Console.WriteLine($"Type:{Type} \n ID : {Identificator} \n Value of money : {valueOfMoney}");
        }

        public void withdraw(decimal output)
        {
            if (valueOfMoney > output)
            {
                valueOfMoney -= output;
            }
            else
            {
                Console.WriteLine("Недостаточно денег для снятия");
            }
        }
        public void deposit(decimal input)
        {
            valueOfMoney += input;
        }
        public void Moneytransfer(Bank acc, decimal transfer)
        {
            if (transfer <= valueOfMoney)
            {
                this.valueOfMoney -= transfer;
                acc.valueOfMoney += transfer;
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }
        }


        public decimal Money
        {
            get { return valueOfMoney; }
            set { valueOfMoney = value; }
        }
    }

    internal class Program
    {
        static void IfisIFormatTable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {

                Console.WriteLine("Не удалось явно преобразовать к IFormatTable");
            }
        }
        public static char[] Reverse(string a)
        {
            char[] reverse = a.Reverse().ToArray();
            return reverse;
        }
        public static void SearchMail()
        {
            StreamReader info = new StreamReader("info.txt");

            int count = 0;
            string temp;
            while (info.ReadLine()!=null)
            {
                count++;
            }
           info = new StreamReader("info.txt");
           
           for (int i=0; i<count; i++)
            {
                string[] mailinf = info.ReadLine().Replace(" ","").Split('#');
                temp = mailinf[1];
                File.AppendAllText("info2.txt",temp+ "\n");
            }
            
        }
        
    
        public static string Swap(string s)
        {
            char[] st = s.ToCharArray();
            Array.Reverse(st);
            string finalst = new string(st);
            return finalst;
        }
        class Song
        {
            private string name; //название песни
            private string author; //автор песни
            public Song(string name, string author)
            {
                this.author = author;
                this.name = name;
            }
               public string Name
            {
                get { return name; }
            }
            public string Author
            {
                get { return author; }
            }
            public string Title()
            {
                return name + " " + author;
            }
            public override bool Equals(object obj)
            {
                if (obj.GetType() != this.GetType())
                {
                    return false;
                }
                Song song = obj as Song;
                return (this.name == song.name) && (this.author == song.author);
            }
            public static void SearchEqualsSongs(List<Song> songs)
            {
                bool isFonded = false;
                for (int i = 0; i < songs.Count; i++)
                {
                    for (int j = i + 1; j < songs.Count; j++)
                    {
                        if (songs[i].Equals(songs[j]))
                        {
                            isFonded = true;
                            Console.WriteLine($"Совпали песни под номерами {i + 1} и {j + 1}");
                            Console.WriteLine($"Песня под названием {songs[i].name} , автор {songs[i].author}");
                        }
                    }
                }
                if (!isFonded)
                {
                    Console.WriteLine("Одинаковых песен не найдено");
                }
            }
        }
   
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Упражнение 8.1");
            //var bankinfo = new Bank();
            //bool flag = true;
            //Bank save = new Bank();
            //Bank corrent = new Bank();

            //while (flag)
            //{
            //    Console.WriteLine("Введите команды:заполнить сберегательный, заполнить текущий, вывести сберегательный,вывести текущий, снять со счета, положить на счет, выход, перевести");

            //    string act = Console.ReadLine().ToLower();
            //    if (act.Equals("выход"))
            //    {
            //        flag = false;
            //    }
            //    else if (act.Equals("заполнить сберегательный"))
            //    {
            //        Console.WriteLine("Введите сумму");
            //        decimal money;
            //        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            //        {
            //            Console.WriteLine("Введите целое число ");
            //        }
            //        save.FillSaving(money);

            //    }
            //    else if (act.Equals("заполнить текущий"))
            //    {
            //        Console.WriteLine("Введите сумму");
            //        decimal money;
            //        while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            //        {
            //            Console.WriteLine("Введите целое число ");
            //        }
            //        corrent.FillCorrent(money);
            //    }
            //    else if (act.Equals("вывести сберегательный"))
            //    {
            //        save.WriteTheDataOfSavingType();
            //    }
            //    else if (act.Equals("вывести текущий"))
            //    {
            //        corrent.WriteTheDataOfCorrentType();
            //    }

            //    else if (act.Equals("снять со счета"))
            //    {
            //        decimal output;
            //        Console.Write("Choose the type of account : saving or corrent\t\t");
            //        string type0 = Console.ReadLine().ToLower();
            //        if (type0.Equals("saving"))
            //        {
            //            Console.Write("введите сумму");
            //            decimal money;
            //            while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            //            {
            //                Console.WriteLine("Incorrect volue money");
            //            }
            //            save.deposit(money);
            //        }
            //        else if (type0.Equals("corrent"))
            //        {
            //            Console.Write("введите сумму ");
            //            decimal money;
            //            while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            //            {
            //                Console.WriteLine("Incorrect volue money");
            //            }
            //            corrent.deposit(money);
            //        }
            //    }



            //    else if (act.Equals("перевести"))
            //    {
            //        Console.WriteLine("from corrent or saving?");
            //        string str = Console.ReadLine();
            //        if (Equals(str, "corrent"))
            //        {
            //            Console.WriteLine("Сколько?");
            //            decimal transfer;
            //            while (!decimal.TryParse(Console.ReadLine(), out transfer) || transfer < 0)
            //            {
            //                Console.WriteLine("Incorrect value of money");
            //            }
            //            corrent.Moneytransfer(save, transfer);
            //        }
            //        if (Equals(str, "saving"))
            //        {
            //            Console.WriteLine("Сколько?");
            //            decimal transfer;
            //            while (!decimal.TryParse(Console.ReadLine(), out transfer) || transfer < 0)
            //            {
            //                Console.WriteLine("Incorrect value of money");
            //            }
            //            save.Moneytransfer(corrent, transfer);
            //        }
            //    }
            //    else if (act.Equals("снять"))
            //    {
            //        Console.Write("Choose the type of account : saving or corrent\t\t");
            //        string type0 = Console.ReadLine().ToLower();
            //        if (type0.Equals("saving"))
            //        {
            //            Console.Write("введите сумму ");
            //            decimal money;
            //            while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            //            {
            //                Console.WriteLine("Incorrect volue money");
            //            }
            //            save.withdraw(money);
            //        }
            //        else if (type0.Equals("corrent"))
            //        {
            //            Console.Write("введите сумму");
            //            decimal money;
            //            while (!decimal.TryParse(Console.ReadLine(), out money) || money < 0)
            //            {
            //                Console.WriteLine("Incorrect volue money");
            //            }
            //            corrent.withdraw(money);
            //        }
            //    }


            //    Console.WriteLine("Упражнение 8.2");
            //    Console.WriteLine("Введите строку");
            //    string s = Console.ReadLine();
            //    Console.WriteLine(Swap(s));


            //Console.WriteLine("Упражнение 8.3");
            //Console.WriteLine("Введите имя файла");
            //string file = Console.ReadLine()+".txt";
            //if (File.Exists(file) && !file.Equals("2.txt"))
            //{
            //    StreamReader f = new StreamReader(file);
            //    file = f.ReadToEnd().ToUpper();
            //    File.AppendAllText("2.txt", file);
            //    f.Close();
            //}
            //else
            //{
            //    Console.WriteLine("Файл не найден");
            //}

            //Console.WriteLine("Упражение 8.4");
            //Console.Write("Введите строку-->\t");
            //object obj = Console.ReadLine();
            //IfisIFormatTable(obj);
            //Console.Clear();

            Console.WriteLine("Домашняя работа  8.1");
            SearchMail();


            Console.WriteLine("Домашняя работа  8.2");

            List<Song>  songs = new List<Song>();
            int counsong = 4;
            for (int i = 0; i < counsong; i++)
            {
                Console.WriteLine("Введите название песни");
                string name = Console.ReadLine();
                Console.WriteLine("Введите артиста");
                string author = Console.ReadLine();
                songs.Add(new Song(name, author));
            }
            Song.SearchEqualsSongs(songs);

            Console.WriteLine("Домашняя работа ");


            Console.ReadKey();

            }
        }
    }



