// Написать программу, которая из имеющегося массива строк формирует массив строк длина которых меньше или равна 3 символа.

class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] spled = text.Split(new char[]{' ', ':','.',',', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            var res = from word in spled
                      where word.Length <= 3
                      select word;
            if (res.Count() <= 0)
            {
                Console.WriteLine("no 3 length words");
            }
            else
            {
                foreach (string s in res)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }