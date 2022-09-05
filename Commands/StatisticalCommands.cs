/* File Name: StatisticalCommands.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Last Date Published: Dec. 24 2020
 */

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpBotv2.Commands
{
    public sealed class StatisticalCommands : BaseCommandModule
    {
        [Command("Mean")]
        [Description("Finds the mean of a set of numbers")]
        public async Task Mean(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach (var num in nums)
            {
                arr.Add(num);
            }
            await ctx.Channel.SendMessageAsync(mean(arr).ToString()).ConfigureAwait(false);
        }

        [Command("Sort")]
        [Description("Sorts a set of numbers")]
        public async Task Sort(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach (var num in nums)
            {
                arr.Add(num);
            }
            arr.Sort();
            string finalSet = "";
            foreach (var c in arr)
            {
                finalSet += c.ToString() + " ";
            }
            await ctx.Channel.SendMessageAsync(finalSet).ConfigureAwait(false);
        }

        [Command("Median")]
        [Description("Finds the median of a set of numbers")]
        public async Task Median(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach (var num in nums)
            {
                arr.Add(num);
            }
            if (arr.Count % 2 == 0)
            {
                await ctx.Channel.SendMessageAsync(median1(arr).ToString()).ConfigureAwait(false);
            }
            else if (arr.Count % 2 != 0)
            {
                await ctx.Channel.SendMessageAsync(median2(arr).ToString()).ConfigureAwait(false);
            }
        }

        [Command("Mode")]
        [Description("Finds the mode of a set of numbers")]
        public async Task Mode(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            if (mode(nums) == 0)
            {
                await ctx.Channel.SendMessageAsync("No mode").ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync(mode(nums).ToString()).ConfigureAwait(false);
            }
        }

        [Command("Variance")]
        [Description("Finds the variance of a set of numbers")]
        public async Task Variance(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params double[] nums)
        {
            List<double> arr = new List<double>();
            foreach(var c in nums)
            {
                arr.Add(c);
            }
            await ctx.Channel.SendMessageAsync(variance(arr).ToString()).ConfigureAwait(false);
        }

        [Command("Standarddevi")]
        [Description("Finds the standard deviation of a set of numbers")]
        public async Task Standarddevi(CommandContext ctx,
            [Description("Set of Data(numbers space delimited)")] params double[] nums)
        {
            List<double> arr = new List<double>();
            foreach(var c in nums)
            {
                arr.Add(c);
            }
            await ctx.Channel.SendMessageAsync(Math.Sqrt(variance(arr)).ToString()).ConfigureAwait(false);
        }

        [Command("Meandevi")]
        [Description("Finds the mean absolute deviation of a set of numbers")]
        public async Task Meandevi(CommandContext ctx,
            [Description("Set of Data(numbers space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach(var c in nums)
            {
                arr.Add(c);
            }
            await ctx.Channel.SendMessageAsync(meanDeviation(arr).ToString()).ConfigureAwait(false);
        }

        [Command("Mediandevi")]
        [Description("Finds the median absolute deviation of a set of numbers")]
        public async Task Mediandevi(CommandContext ctx,
           [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach (var num in nums)
            {
                arr.Add(num);
            }
            if (arr.Count % 2 == 0)
            {
                await ctx.Channel.SendMessageAsync(medianDeviation1(arr).ToString()).ConfigureAwait(false);
            }
            else if (arr.Count % 2 != 0)
            {
                await ctx.Channel.SendMessageAsync(medianDeviation2(arr).ToString()).ConfigureAwait(false);
            }
        }

        [Command("Min")]
        [Description("Finds the smallest value in a set of numbers")]
        public async Task Min(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach(var num in nums)
            {
                arr.Add(num);
            }
            await ctx.Channel.SendMessageAsync(arr.Min().ToString()).ConfigureAwait(false);
        }

        [Command("Max")]
        [Description("Finds the largest value in a set of numbers")]
        public async Task Max(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach(var num in nums)
            {
                arr.Add(num);
            }
            await ctx.Channel.SendMessageAsync(arr.Max().ToString()).ConfigureAwait(false);
        }

        [Command("Sum")]
        [Description("Gets the sum of all the numbers together in a set of numbers")]
        public async Task Sum(CommandContext ctx,
            [Description("Set of Data(numbers, space delimited)")] params decimal[] nums)
        {
            List<decimal> arr = new List<decimal>();
            foreach(var num in nums)
            {
                arr.Add(num);
            }
            await ctx.Channel.SendMessageAsync(arr.Sum().ToString()).ConfigureAwait(false);
        }


        //Helper Functions/Methods 
        private decimal mean(List<decimal> arr)
        {
            decimal sum = 0;
            decimal average = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Count;
            return average;
        }
        private decimal median1(List<decimal> arr)//for even lists
        {
            arr.Sort();
            decimal firstNum;
            decimal secondNum;
            decimal median;

            firstNum = arr[arr.Count / 2];
            secondNum = arr[(arr.Count / 2)];
            median = (firstNum + secondNum) / 2;

            return median;
        }
        private decimal median2(List<decimal> arr)//for odd lists
        {
            arr.Sort();
            decimal median;
            median = arr[(arr.Count / 2)];
            return median;
        }
        private decimal mode(decimal[] arr)
        {
            Dictionary<decimal, decimal> counts = new Dictionary<decimal, decimal>();
            foreach (int a in arr)
            {
                if (counts.ContainsKey(a))
                {
                    counts[a] = counts[a] + 1;
                }
                else
                {
                    counts[a] = 1;
                }
            }
            decimal result = decimal.MinValue;
            decimal max = decimal.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
                else if (counts[key] == max)
                {
                    result = 0; //Indicating no mode
                }
            }
            return result;
        }
        private double variance(List<double> arr)
        {
            //Mean first
            double sum = 0;
            double average = 0;
            List<double> resultsArr = new List<double>();
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }
            average = sum / arr.Count;

            foreach (var c in arr)
            {
                resultsArr.Add(Math.Pow(c - average, 2));
            }
            //Now find the mean for resultsArr 
            double sum2 = 0;
            double average2 = 0;
            for (int i = 0; i < resultsArr.Count; i++)
            {
                sum2 += resultsArr[i];
            }
            average2 = sum2 / resultsArr.Count;

            return average2;
        }
        private decimal meanDeviation(List<decimal> arr)
        {
            List<decimal> distanceArr = new List<decimal>();
            decimal absSum = 0;

            for (int i = 0; i < arr.Count; i++)
                absSum = absSum + Math.Abs(arr[i]
                                    - mean(arr));
            // Return mean absolute  
            // deviation about mean. 
            return absSum / arr.Count;
        }
        private decimal medianDeviation1(List<decimal> arr)
        {
            List<decimal> distanceArr = new List<decimal>();
            decimal tempMedian;
            decimal realMedian;
            tempMedian = median1(arr);
            for (int i = 0; i < arr.Count; i++)
            {
                distanceArr.Add(arr[i] - tempMedian);
            }
            realMedian = median1(distanceArr);
            return realMedian;
        }
        private decimal medianDeviation2(List<decimal> arr)
        {
            List<decimal> distanceArr = new List<decimal>();
            decimal tempMedian;
            decimal realMedian;
            tempMedian = median2(arr);
            for (int i = 0; i < arr.Count; i++)
            {
                distanceArr.Add(arr[i] - tempMedian);
            }
            realMedian = median2(distanceArr);
            return realMedian;
        }
    }
}
