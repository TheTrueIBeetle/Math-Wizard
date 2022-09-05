/* File Name: OperationCommands.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Last Date Published: Sep. 15 2020
 */

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBotv2.Commands
{
    public sealed class OperationCommands : BaseCommandModule
    {
        [Command("Add")] //Tag the commands first
        [Description("Adds two numbers together")]
        public async Task Add(CommandContext ctx, 
            [Description("First Number")]decimal num1,
            [Description("Second Number")]decimal num2)
        {
            await ctx.Channel.SendMessageAsync(add(num1, num2).ToString()).ConfigureAwait(false);
        }

        [Command("Subtract")]
        [Description("Subtracts a number from another number")]
        public async Task Subtract(CommandContext ctx,
            [Description("First Number")] decimal num1,
            [Description("Second Number")] decimal num2)
        {
            await ctx.Channel.SendMessageAsync(subtract(num1, num2).ToString()).ConfigureAwait(false);
        }

        [Command("Multiply")]
        [Description("Multiplies two numbers together")]
        public async Task Multiply(CommandContext ctx,
            [Description("First Number")] decimal num1,
            [Description("Second Number")] decimal num2)
        {
            await ctx.Channel.SendMessageAsync(multiply(num1, num2).ToString()).ConfigureAwait(false);
        }

        [Command("Divide")]
        [Description("Divides a number by another number")]
        public async Task Divide(CommandContext ctx,
            [Description("First Number")] decimal num1,
            [Description("Second Number")] decimal num2)
        {
            await ctx.Channel.SendMessageAsync(divide(num1, num2).ToString()).ConfigureAwait(false);
            //await ctx.Channel.SendMessageAsync("Remainder " + modulus(num1, num2)).ConfigureAwait(false);
            if (num1 % num2 == 0)
            {
                await ctx.Channel.SendMessageAsync(num1 + " Divides evenly").ConfigureAwait(false);
            }
        }

        [Command("Mod")]
        [Description("Does modulus division on a number by another number")]
        public async Task Modulus(CommandContext ctx,
            [Description("First Number")] decimal num1,
            [Description("Second Number")] decimal num2)
        {
            await ctx.Channel.SendMessageAsync(modulus(num1, num2).ToString()).ConfigureAwait(false);
        }

        [Command("Power")]
        [Description("Gives the product from raising a number to the power of another number")]
        public async Task Power(CommandContext ctx,
            [Description("First Number")] decimal num1,
            [Description("Second Number")] decimal num2)
        {
            await ctx.Channel.SendMessageAsync(power(num1, num2).ToString()).ConfigureAwait(false);
        }

        [Command("Sqrt")]
        [Description("Finds the square root of a number")]
        public async Task Sqrt(CommandContext ctx,[Description("Number")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(Math.Sqrt((double)num).ToString()).ConfigureAwait(false); //TODO: Casting to double here
        }                                                                                                //      for now.   

        [Command("Floor")]
        [Description("Gives the closest integral value less than the specified number")]
        public async Task Floor(CommandContext ctx,[Description("Number")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(Math.Floor(num).ToString()).ConfigureAwait(false);
        }

        [Command("Ceiling")]
        [Description("Gives the closest integral value greater than the specified number")]
        public async Task Ceiling(CommandContext ctx,[Description("Number")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(Math.Ceiling(num).ToString()).ConfigureAwait(false);
        }

        [Command("Cbrt")]
        [Description("Finds the cubic root of a number")]
        public async Task Cbrt(CommandContext ctx,[Description("Number")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(Math.Cbrt((double)num).ToString()).ConfigureAwait(false); //TODO: Casting to double here
        }                                                                                                //      for now.

        [Command("Round")]
        [Description("Rounds the specified number to closest integral value, or midpoint values to the nearest even number ")]
        public async Task Round(CommandContext ctx,[Description("Number")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(Math.Round(num).ToString()).ConfigureAwait(false);
        }

        [Command("Nthrt")]
        [Description("Finds the nth root of a number")]
        public async Task Nthrt(CommandContext ctx,
            [Description("First Number")] decimal num1,
            [Description("Nth Root Number")] long num2)
        {
            await ctx.Channel.SendMessageAsync(nthroot(num1, num2).ToString()).ConfigureAwait(false);
        }

        [Command("Factorial")]
        [Description("Finds the factorial of a given number")]
        public async Task Factorial(CommandContext ctx, [Description("Number")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(factorial(num).ToString()).ConfigureAwait(false);
        }

        [Command("PrimeFactors")]
        [Description("Finds all the prime factors of a number")]
        public async Task PrimeFactors(CommandContext ctx,[Description("Number")] long num)
        {
            //Embed Stuff
           /* var errorEmbed = new DiscordEmbedBuilder
            {
                Title = "Error",
                Color = DiscordColor.Purple
            };
            errorEmbed.AddField(null, "Sorry, but discord won't allow me to send more than 2000 characters"
                        + ", and this number you gave me will create a list of numbers greater than that character count.");
                        */
            if (num > 2000)
            {
                await ctx.Channel.SendMessageAsync("Sorry, but discord won't allow me to send more than 2000 characters"
                        + ", and this number you gave me will create a list of numbers greater than that character count").ConfigureAwait(false);
              /*  var fileName = "primeNums.txt";

                using FileStream fs = File.Create(fileName);
                using var sr = new StreamWriter(fs);

                sr.WriteLine(pf(num));
         
                Console.WriteLine("done");
                
                await ctx.Member.SendFileAsync(fs).ConfigureAwait(false);
                await ctx.Channel.SendMessageAsync("I sent you a file with the data in it since you are asking for a number greater than 2000").ConfigureAwait(false);
                */
            }
            else
            {
                await ctx.Channel.SendMessageAsync(pf(num)).ConfigureAwait(false);
            }
        }


        //Helper Functions/Methods 
        private decimal add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        private decimal subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        private decimal multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        private decimal divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        private decimal modulus(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
        private decimal power(decimal num1, decimal num2) //Public so stat command can use it //TODO: figure out this behaviour
        {
            int count = 1;
            decimal pow = num1; 
            while (count < num2)
            {
                pow *= num1;
                count++;
            }
            return pow;
        }
        private decimal nthroot(decimal num1, long N)
        {
            decimal epsilon = 0.00001m;//
            decimal n = N;
            decimal x = num1 / n;
            while (Math.Abs(num1 - power(x, N)) > epsilon)
            {
                x = (1.0m / n) * ((n - 1) * x + (num1 / (power(x, N - 1))));
            }
            return x;
        }
        private string pf(long num)
        {
            List<long> primeList = new List<long>();
            StringBuilder returnString = new StringBuilder();
            long flag_var, i, j;
            for (i = 1 + 1; i < num; ++i)
            {
                flag_var = 0;
                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag_var = 1;
                        break;
                    }
                }
                if (flag_var == 0)
                {
                    primeList.Add(i);
                }
            }
            primeList.Sort();
            long count = 0;
            foreach(var c in primeList)
            {
                ++count;
                returnString.Append(c);
                if (count == primeList.Count)
                {
                    break;
                }
                else
                {
                    returnString.Append(", ");
                }
            }
            string finalString = returnString.ToString();
            return finalString;
            
        }
        private decimal factorial(decimal number)
        {
            decimal fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }


    }
}
