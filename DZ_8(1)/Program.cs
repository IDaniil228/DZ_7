using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees Semen = new Employees("Semen");

            Employees Rashid = new Employees("Rashid", "superiors", Semen);
            Employees Lucas = new Employees("Lucas", "finance", Rashid);

            Employees O_Ilham = new Employees("O_Ilham", "superiors", Semen);

            Employees Orkady = new Employees("Orkady", "automation", O_Ilham);
            Employees Volody = new Employees("Volody", "automation", O_Ilham);

            Employees Ilshat = new Employees("Ilshat", "system", Orkady, Volody);            
            Employees Ivanch = new Employees("Ivanch", "system", Ilshat);
            Employees Ilya = new Employees("Ivanch", "system", Ivanch);
            Employees Vity = new Employees("Vity", "system", Ivanch);
            Employees Zhenya = new Employees("Zhenya", "system", Ivanch);

            Employees Sergey = new Employees("Sergey", "develop", Orkady, Volody);
            Employees Laysan = new Employees("Laysan", "develop", Sergey);
            Employees Marat = new Employees("Marat", "develop", Laysan);
            Employees Dina = new Employees("Dina", "develop", Laysan);
            Employees Anton = new Employees("Anton", "develop", Laysan);
            Employees Ildar = new Employees("Ildar", "develop", Laysan);

            Task task_1 = new Task("Пофиксить баги", "develop", Semen, Dina);
            Console.WriteLine($"От человека {task_1.GetFromName} даётся задача '{task_1.Name}' человеку {task_1.GetToName}");
            if (task_1.IsBoss(task_1.GetFrom, task_1.GetTo))
            {
                Console.WriteLine("Сотрудник взял задачу");
            }
            else 
            {
                Console.WriteLine("Сотрудник не взял задачу");
            }

            Task task_2 = new Task("Сделать так, чтобы бухгалтерия нажимала на кнопочку и все работало", "superiors", Semen, O_Ilham);
            Console.WriteLine($"От человека {task_2.GetFromName} даётся задача '{task_2.Name}' человеку {task_2.GetToName}");
            if (task_1.IsBoss(task_2.GetFrom, task_2.GetTo))
            {
                Console.WriteLine("Сотрудник взял задачу");
            }
            else
            {
                Console.WriteLine("Сотрудник не взял задачу");
            }

            Task task_3 = new Task("Создать сервер", "system", Volody, Ilshat);
            Console.WriteLine($"От человека {task_3.GetFromName} даётся задача '{task_3.Name}' человеку {task_3.GetToName}");
            if (task_1.IsBoss(task_3.GetFrom, task_3.GetTo))
            {
                Console.WriteLine("Сотрудник взял задачу");
            }
            else
            {
                Console.WriteLine("Сотрудник не взял задачу");
            }
            Console.ReadKey(); 
        }
    }
}
