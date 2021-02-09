using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YP_7
{
    public class Stringer
    {
        public void regFirstLast()
        {
            Regex regex = new Regex(@"^\w+\s");
            Regex regex2 = new Regex(@"\s\w+$");

            Console.WriteLine("Введите 2 строки для проверки: ");
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();

            string newStr = regex.Match(str).Value;
            string newStr2 = regex2.Match(str2).Value;

            newStr = newStr.Trim();
            newStr2 = newStr2.Trim();

            if (newStr != newStr2)
            {
                string output = "";
                for (int i = 0; i < 3; i++)
                {
                    output += newStr + " " + newStr2 + " ";
                }
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine($"Первое слово и последнее - совпадают = {newStr}");
            }
        }

        public void strPovt()
        {
            Console.WriteLine("Введите предложение: ");
            string sentence = Console.ReadLine();

            string[] mas = sentence.Split(' ');
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] == mas[j])
                    {
                        mas[j] = "";                       
                    }
                }
            }

            foreach (var item in mas)
            {
                if (item != "")
                    Console.Write(item + " ");
            }
        }

        public void Encrypt()
        {
            // "В ексипаз аволс :ынаворфишаз еоджак зи хин онасипаз .торобоан ьтаворфишсаР еинещбоос";
            Console.WriteLine("Введите фразу наоборот");
            string input = Console.ReadLine();
            string result = string.Join(" ", input.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(result);
        }

        public void Email()
        {
            //"abcd@efg.com this is just some text. these are just some numbers",
            //"abcd@efg.com mnop@qrs.com This is just some text. these are just some numbers 123456",
            //"abcd@efg.com mnop@qrs.com uvw@xyz.com This is just some text. these are just some numbers 123456 asdad"
            string c;
            Console.WriteLine("Введите строку с email-ми: ");
            c = Console.ReadLine();
            var strs = new List<string> { c };
            for (int i = 0; i < c.Length; i++)
            {
                strs = new List<string> { c };
            }
            foreach (var s in strs)
            {
                var results = Regex.Matches(s, @"(?i)\G\s*([A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6})").Cast<Match>().Select(x => x.Groups[1].Value);
                Console.WriteLine(string.Join(" | ", results));
            }
        }

        public void Year()
        {
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if (year >= 1983 && year <= 2024)
            {
                Console.WriteLine("Число поподает в даипозон: [1983, 2024]");
            }
            else
            {
                Console.WriteLine("Число НЕ поподает в даипозон: [1983, 2024]");
            }
        }
    }
}
