using DSharpPlus.Entities;
using System;

namespace CSharpBotv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
        
            bot.RunAsync().GetAwaiter().GetResult();

        }
    }
}
