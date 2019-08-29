using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace TelegramBot
{
    class Program
    {
        private static readonly Dictionary<string, string> data;

        static Program()
        {
            var d = File.ReadAllText(@"C:\Users\n.goguev\source\repos\TelegramBot\TelegramBot\answerData.json");
            data = JsonConvert.DeserializeObject<Dictionary<string, string>>(d);
            
        }
        static void Main(string[] args)
        {
            var api = new TelegramAPI();
            api.SendApiRequest("getMe");
            //while (true)
            //{
            //    if (AnswerQuetion() == false)
            //    {
            //        break;
            //    }
            //}
            Console.ReadLine();
        }

        private static bool AnswerQuetion()
        {
            var question = Console.ReadLine().ToLower();
            var answer = "";
            foreach (var e in data)
            {
                if (question.Contains(e.Key))
                {
                    answer += e.Value;
                }
            }
            Console.WriteLine(answer);
            return false;
        }
    }
}
