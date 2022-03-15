using System;

namespace AP204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;


            string str = "bU tasKI metHodla yAzmAliSiz";

            string lower = str.ToLower();

            string sentences = lower.Replace("b", "B");
            sentences = sentences.Replace("task", "Task");
            sentences = sentences.Replace("methodla", "Methodla");
            sentences = sentences.Replace("y", "Y");

            
            Console.WriteLine(sentences);



        }
    }
}
