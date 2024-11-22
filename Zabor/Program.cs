using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ArtLib;
namespace Zabor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Список
            List<int> list = new List<int>();
            string input = "input.txt";
            string output = "output.txt";
            //Объект FileInfo
            FileInfo file = new FileInfo(input);
         
            //Проверка на существование
            if (!File.Exists(input))
            {
                Console.WriteLine("Файл не найден");
            }
            //Проверка на пустоту
            else if (file.Length == 0)
            {
                Console.WriteLine("Файл пустой");
            }   
     
            else
            {
                try
                {
                    StreamReader sr = File.OpenText(input);
                    sr.ReadLine();
                    //Чтение
                    string[] m = sr.ReadLine().Split(' ');
                    for (int i = 0; i < m.Length; i++)
                    {
                        list.Add(Convert.ToInt32(m[i]));
                    }
                    sr.Close();
                    //Запись
                    StreamWriter sw = File.CreateText(output);
                    sw.WriteLine(Calculate.Calcl(list));
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}
