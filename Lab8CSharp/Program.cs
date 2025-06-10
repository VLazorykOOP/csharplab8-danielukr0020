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



//using System;
//using System.IO;
//using System.Text.RegularExpressions;

//class Program2
//{
//    static void Main()
//    {
//        string inputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\input2.txt";
//        string outputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\output2.txt";

//        // Читання всього тексту з файлу
//        string inputText = File.ReadAllText(inputFilePath);

//        // Регулярний вираз для пошуку слів, які треба видалити:
//        // 1. Однобуквені слова (наприклад "a", "I")
//        // 2. Слова, що починаються на 'a', 'b', 'c', 'd' або 'e'
//        string pattern = @"\b[a-eA-E]\b|\b[a-eA-E]\w*\b";

//        // Видалення цих слів з тексту
//        string resultText = Regex.Replace(inputText, pattern, string.Empty);

//        // Очищення зайвих пробілів після видалення слів
//        resultText = Regex.Replace(resultText, @"\s+", " ").Trim();

//        // Запис результату в новий файл
//        File.WriteAllText(outputFilePath, resultText);

//        Console.WriteLine($"Результат записано в файл {outputFilePath}.");
//    }
//}



//using System;
//using System.IO;
//using System.Text.RegularExpressions;
//using System.Collections.Generic;

//class Program3
//{
//    static void Main()
//    {
//        string inputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\input3.txt";
//        string outputFilePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\output3.txt";

//        // Зчитування вхідного тексту
//        string inputText = File.ReadAllText(inputFilePath);

//        // Виділення слів (без розділових знаків)
//        MatchCollection matches = Regex.Matches(inputText, @"\b\w+\b");

//        List<string> palindromes = new List<string>();

//        foreach (Match match in matches)
//        {
//            string word = match.Value;
//            if (IsPalindrome(word))
//            {
//                palindromes.Add(word);
//            }
//        }

//        // Запис результату у вихідний файл
//        File.WriteAllLines(outputFilePath, palindromes);

//        Console.WriteLine($"Знайдено {palindromes.Count} симетричних слів. Результат записано в {outputFilePath}.");
//    }

//    // Метод для перевірки чи слово паліндром
//    static bool IsPalindrome(string word)
//    {
//        word = word.ToLower(); // Робимо перевірку нечутливою до регістру
//        int len = word.Length;
//        for (int i = 0; i < len / 2; i++)
//        {
//            if (word[i] != word[len - i - 1])
//                return false;
//        }
//        return true;
//    }
//}

//using System;
//using System.IO;

//class Program4
//{
//    static void Main()
//    {
//        string filePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\fibonacci.bin";

//        Console.Write("Введіть кількість чисел Фібоначчі (n): ");
//        int n = int.Parse(Console.ReadLine());

//        // Створюємо і записуємо n чисел Фібоначчі у двійковий файл
//        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
//        {
//            long a = 0, b = 1;
//            for (int i = 0; i < n; i++)
//            {
//                writer.Write(a);
//                long temp = a + b;
//                a = b;
//                b = temp;
//            }
//        }

//        Console.WriteLine("\nЧисла Фібоначчі з номерами, не кратними 3:");

//        // Зчитуємо числа з файлу і виводимо ті, які не кратні 3
//        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
//        {
//            int index = 1;
//            while (reader.BaseStream.Position < reader.BaseStream.Length)
//            {
//                long value = reader.ReadInt64();
//                if (index % 3 != 0)
//                {
//                    Console.WriteLine($"{index}: {value}");
//                }
//                index++;
//            }
//        }
//    }
//}


//using System;
//using System.IO;

//class Program5
//{
//    static void Main()
//    {
//        string basePath = @"C:\Users\maria\Source\Repos\csharplab8-Marian91771\Lab8CSharp\temp";

//        // 1. Створення папок vybyranyi1 і vybyranyi2
//        string dir1 = Path.Combine(basePath, "vybyranyi1");
//        string dir2 = Path.Combine(basePath, "vybyranyi2");

//        Directory.CreateDirectory(dir1);
//        Directory.CreateDirectory(dir2);

//        // 2. Створення файлів t1.txt і t2.txt у vybyranyi1
//        string file1 = Path.Combine(dir1, "t1.txt");
//        string file2 = Path.Combine(dir1, "t2.txt");

//        File.WriteAllText(file1, "Вибираний Мар'ян Вячеславович 2006 року народження, місце проживання м Тернопіль");
//        File.WriteAllText(file2, "Кривий Андрій Васильович, 2004 року народження, місце проживання с Гусятин");

//        // 3. Створення файлу t3.txt у vybyranyi2, об’єднання вмісту t1.txt і t2.txt
//        string file3 = Path.Combine(dir2, "t3.txt");
//        string combinedText = File.ReadAllText(file1) + "\n" + File.ReadAllText(file2);
//        File.WriteAllText(file3, combinedText);

//        // 4. Вивід інформації про файли
//        Console.WriteLine("Інформація про створені файли:");
//        PrintFileInfo(file1);
//        PrintFileInfo(file2);
//        PrintFileInfo(file3);

//        // 5. Перемістити t2.txt у vybyranyi2
//        string newFile2 = Path.Combine(dir2, "t2.txt");
//        File.Move(file2, newFile2);

//        // 6. Копіювати t1.txt у vybyranyi2
//        string copiedFile1 = Path.Combine(dir2, "t1.txt");
//        File.Copy(file1, copiedFile1);

//        // 7. Перейменувати vybyranyi2 → ALL, vybyranyi1 видалити
//        string allDir = Path.Combine(basePath, "ALL");
//        Directory.Move(dir2, allDir);
//        Directory.Delete(dir1, true);

//        // 8. Вивести повну інформацію про файли в папці ALL
//        Console.WriteLine("\nІнформація про файли в папці ALL:");
//        foreach (string file in Directory.GetFiles(allDir))
//        {
//            PrintFileInfo(file);
//        }
//    }

//    static void PrintFileInfo(string filePath)
//    {
//        FileInfo fi = new FileInfo(filePath);
//        Console.WriteLine($"Файл: {fi.Name}");
//        Console.WriteLine($"   Повний шлях: {fi.FullName}");
//        Console.WriteLine($"   Розмір: {fi.Length} байт");
//        Console.WriteLine($"   Створено: {fi.CreationTime}");
//        Console.WriteLine($"   Останній доступ: {fi.LastAccessTime}");
//        Console.WriteLine($"   Останнє редагування: {fi.LastWriteTime}");
//        Console.WriteLine();
//    }
//}
