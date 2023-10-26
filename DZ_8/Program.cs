using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace DZ_8
{
    internal class Program
    {
        public static void IsInterface(object q)
        {
            if (q is IFormattable)
            {
                Console.WriteLine("Входной параметр реализует интерфейс System.IFormattable.");
            }
            else 
            {
                Console.WriteLine("Входной параметр не реализует интерфейс System.IFormattable.");
            }
        }
        public static string ReString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string str_2 = string.Join("", chars);
            return str_2;
        }

        public static void SearchMail(ref string s)
        {
            string[] words = s.Split('#');
            s = words[1];
        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Set(10000, 1);
            account.Transfer(account, 5000);
            Console.WriteLine($"Ваш баланс стал равен - {account.Balance}");
            Console.ReadKey();

            Console.WriteLine("Упражнение 8.2, Метод со строками");
            string str = Console.ReadLine();
            Console.WriteLine($"Строка в обратном порядке - {ReString(str)}");
            Console.ReadKey();

            Console.WriteLine("Упражнение 8.3 Записать текст из файла в другой файл");
            Console.WriteLine("Введите название файла");
            string fileName = Console.ReadLine();
            string path = Environment.CurrentDirectory + @"\" + fileName;
            if (File.Exists(path))
            {
                string fileText = File.ReadAllText(path).ToUpper();
                File.WriteAllText(Environment.CurrentDirectory + @"\outFile", fileText);
            }
            else
            {
                Console.WriteLine("Такого файла не существует!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            Console.ReadKey();

            Console.WriteLine("Упражнение 8.4 Реализовать метод, который проверяет реализует" +
                " ли входной парамет метода интерфейс System.IFormattable.");
            IFormattable formattable = 0;
            IsInterface(formattable);
            Console.ReadKey();

            Console.WriteLine("Домашнее задание 8.1 Файл с элект. почтой");
            string s;
            StreamReader f = new StreamReader("NameAndMails.txt");
            while ((s = f.ReadLine()) != null)
            {
                SearchMail(ref s);
                using (var writer = new StreamWriter("Mails.txt", true))
                {
                    writer.WriteLine(s);
                }
            }
            Console.WriteLine("Все готово!");
            Console.ReadKey();



            Console.WriteLine("Домашнее задание 8.2 Список песен");
            List<Song> songs = new List<Song>();
            Song song_1 = new Song("In the end", "Linkin park");
            Song song_2 = new Song("Without me", "Eminem");
            Song song_3 = new Song("Город под подошвой", "Oxxxymiron");
            Song song_4 = new Song("Sonne", "Rammstein");
            songs.Add(song_1);
            songs.Add(song_2);
            songs.Add(song_3);
            songs.Add(song_4);
            for (int i = 1; i < songs.Count; i++)
            {
                songs[i].Previous = songs[i - 1];
            }

            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].Title());
            }

            if (songs[1].Equals_songs(songs[1].Previous))
            {
                Console.WriteLine("Первая и вторая песни одинаковы");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни - это разные песни");
            }
            
            Console.ReadKey();
        }
    }
}
