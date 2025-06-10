//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.RegularExpressions;

//class Program1
//{
//    static void Main()
//    {
//        string inputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\input1.txt";
//        string outputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\output1.txt";
//        string replacement = "REPLACEMENT"; // Строка для заміни

//        // Читання всього тексту з файлу
//        string inputText = File.ReadAllText(inputFilePath);

//        // Регулярний вираз для пошуку IP-адрес у форматі d.d.d.d
//        string pattern = @"\b([0-9A-Fa-f]{1,2})\.([0-9A-Fa-f]{1,2})\.([0-9A-Fa-f]{1,2})\.([0-9A-Fa-f]{1,2})\b";
//        Regex regex = new Regex(pattern);

//        // Збір всіх знайдених підтекстів
//        MatchCollection matches = regex.Matches(inputText);

//        // Перевірка наявності знайдених IP-адрес
//        if (matches.Count > 0)
//        {
//            List<string> ipAddresses = new List<string>();

//            foreach (Match match in matches)
//            {
//                ipAddresses.Add(match.Value);
//            }

//            // Підрахунок кількості знайдених IP-адрес
//            Console.WriteLine($"Знайдено {ipAddresses.Count} IP-адрес.");

//            // Заміна деяких IP-адрес на задану строку
//            string replacedText = regex.Replace(inputText, replacement);

//            // Запис результату в новий файл
//            File.WriteAllText(outputFilePath, replacedText);

//            Console.WriteLine($"Результат записано в файл {outputFilePath}.");
//        }
//        else
//        {
//            Console.WriteLine("Не знайдено жодної IP-адреси в тексті.");
//        }
//    }
//}
