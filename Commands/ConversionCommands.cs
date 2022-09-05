/* File Name: ConversionCommands.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Last Date Published: Dec. 27 2020
 */

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; //This is library we are using for very large integers
using System.Text.Json;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CSharpBotv2.Commands
{
    public sealed class ConversionCommands : BaseCommandModule
    {
        [Command("Base10to2")]
        [Description("Converts a base 10 decimal number to base 2 binary")]
        public async Task Base10to2(CommandContext ctx, [Description("Integer")] long num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseTentoTwo(num)).ConfigureAwait(false);
        }

        [Command("Base10to16")]
        [Description("Converts a base 10 decimal number to base 16 hexadecimal")]
        public async Task Base10to16(CommandContext ctx, [Description("Integer")] long num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseTentoSixteen(num)).ConfigureAwait(false);
        }

        [Command("Base10to8")]
        [Description("Coverts a base 10 decimal number to base 8 octal")]
        public async Task Base10to8(CommandContext ctx, [Description("Integer")] long num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseTentoEight(num)).ConfigureAwait(false);
        }

        [Command("Base2to10")]
        [Description("Converts a base 2 binary number to base 10 decimal")]
        public async Task Base2to10(CommandContext ctx, [Description("Binary Number")] string num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseTwotoTen(num)).ConfigureAwait(false);
        }

        [Command("Base2to16")]
        [Description("Converts a base 2 binary number to a base 16 hexadecimal")]
        public async Task Base2to16(CommandContext ctx, [Description("Binary Number")] string num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseTwotoSixteen(num)).ConfigureAwait(false);
        }

        [Command("Base2to8")]
        [Description("Converts a base 2 binary number to a base 8 octal")]
        public async Task Base2to8(CommandContext ctx, [Description("Binary Number")] string num)
        {
            string temp = convertBaseTwotoTen(num);
            long decimalNum = Convert.ToInt64(temp);
            string octalNum = convertBaseTentoEight(decimalNum);
            await ctx.Channel.SendMessageAsync(octalNum).ConfigureAwait(false);
        }

        [Command("Base16to10")]
        [Description("Converts a base 16 hexadecimal number to a base 10 decimal")]
        public async Task Base16to10(CommandContext ctx, [Description("Hexadecimal Number")] string num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseSixteentoTen(num)).ConfigureAwait(false);
        }
        [Command("Base16to2")]
        [Description("Converts a base 16 hexadecimal number to a base 2 binary")]
        public async Task Base16to2(CommandContext ctx, [Description("Hexadecimal Number")] string num)
        {
            string temp = convertBaseSixteentoTen(num);
            long decimalNum = Convert.ToInt64(temp);
            string binaryNum = convertBaseTentoTwo(decimalNum);
            await ctx.Channel.SendMessageAsync(binaryNum).ConfigureAwait(false);
        }
        [Command("Base16to8")]
        [Description("Converts a base 16 hexadecimal number to a base 8 octal")]
        public async Task Base16to8(CommandContext ctx, [Description("Hexadecimal Number")] string num)
        {
            string temp = convertBaseSixteentoTen(num);
            long decimalNum = Convert.ToInt64(temp);
            string octalNum = convertBaseTentoEight(decimalNum);
            await ctx.Channel.SendMessageAsync(octalNum).ConfigureAwait(false);
        }

        [Command("Base8to10")]
        [Description("Converts a base 8 octal number to a base 10 decimal")]
        public async Task Base8to10(CommandContext ctx, [Description("Octal Number")] string num)
        {
            await ctx.Channel.SendMessageAsync(convertBaseEighttoTen(num)).ConfigureAwait(false);
        }

        [Command("Base8to2")]
        [Description("Converts a base 8 number to a base 2 binary")]
        public async Task Base8to2(CommandContext ctx, [Description("Octal Number")] string num)
        {
            string temp = convertBaseEighttoTen(num);
            long decimalNum = Convert.ToInt64(temp);
            string binaryNum = convertBaseTentoTwo(decimalNum);
            await ctx.Channel.SendMessageAsync(binaryNum).ConfigureAwait(false);
        }
        [Command("Base8to16")]
        [Description("Converts a base 8 number to a base 16 hexadecimal")]
        public async Task Base8to16(CommandContext ctx, [Description("Octal Number")] string num)
        {
            string temp = convertBaseEighttoTen(num);
            long decimalNum = Convert.ToInt64(temp);
            string hexNum = convertBaseTentoSixteen(decimalNum);
            await ctx.Channel.SendMessageAsync(hexNum).ConfigureAwait(false);
        }

        //Helper Functions
        private string convertBaseTentoTwo(long num)
        {
            string sequence;
            List<long> zeroAndOneList = new List<long>();
            StringBuilder returnString = new StringBuilder();
            returnString.Append("0B ");

            for (int i = 0; num > 0; i++)
            {
                zeroAndOneList.Add(num % 2);
                num /= 2;
            }
            int listLength = zeroAndOneList.Count;
            for (int i = listLength; i != 0; i--)
            {
                returnString.Append(zeroAndOneList[i - 1]);
            }
            sequence = returnString.ToString();
            return sequence;
        }
        private string convertBaseTentoSixteen(long num)
        {
            string sequence;
            bool isLetterPosted = false;
            int numCount = 0;
            int letterCount = 0;
            List<long> hexList = new List<long>();
            List<char> letterList = new List<char>(); 
            List<string> finalList = new List<string>();
            StringBuilder returnString = new StringBuilder();
            StringBuilder finalString = new StringBuilder();

            for (int i = 0; num > 0; i++)
            {
                long tempHex;
                tempHex = num % 16;
                switch (tempHex)
                {
                    case 10:
                        letterList.Add('A');
                        isLetterPosted = true;
                        break;
                    case 11:
                        letterList.Add('B');
                        isLetterPosted = true;
                        break;
                    case 12:
                        letterList.Add('C');
                        isLetterPosted = true;
                        break;
                    case 13:
                        letterList.Add('D');
                        isLetterPosted = true;
                        break;
                    case 14:
                        letterList.Add('E');
                        isLetterPosted = true;
                        break;
                    case 15:
                        letterList.Add('F');
                        isLetterPosted = true;
                        break;
                    default: 
                        hexList.Add(num % 16);
                        isLetterPosted = false;
                        break;
                }
                num /= 16;
                if (isLetterPosted)
                {
                    returnString.Append(letterList[letterCount]); 
                    letterCount++;
                }
                else
                {
                    returnString.Append(hexList[numCount]);
                    numCount++;
                }
            }
            for (int i = 0; i != returnString.Length; i++)
            {
                finalList.Add(returnString[i].ToString());
            }
            finalList.Reverse();
            finalString.Append("0x ");
            for (int i = 0; i != finalList.Count; i++)
            {
                finalString.Append(finalList[i]);
            }
            sequence = finalString.ToString();
            return sequence;
        }
        private string convertBaseTentoEight(long num)
        {
            string sequence;
            List<long> octalList = new List<long>();
            StringBuilder returnString = new StringBuilder();
            returnString.Append("0O ");

            if (num < 8)
            {
                returnString.Append(num);
                return returnString.ToString();
            }
            long quot = num;
            while (quot != 0)
            {
                octalList.Add(quot % 8);
                quot /= 8;
            }

            for (int h = octalList.Count; h != 0; h--)
            {
                returnString.Append(octalList[h - 1]);
            }
            sequence = returnString.ToString();
            return sequence;
        }
        private string convertBaseTwotoTen(string num)
        {
            string sequence;
            List<long> decimalList = new List<long>();
            List<long> bitNumerableList = new List<long>();
            List<int> bitList = new List<int>();
            List<char> charList = new List<char>();
            StringBuilder returnString = new StringBuilder();
            int digitCount = 0;
            foreach (char c in num)
            {
                digitCount++;
                charList.Add(c);
            }
            long bitSum = 1;
            while (digitCount != 0)
            {
                digitCount--;
                bitNumerableList.Add(bitSum);
                bitSum *= 2;
                char foo = charList[digitCount];
                int bar = foo - '0';
                bitList.Add(bar);
                
            }
            long fullSum = 0;
            for (int i = 0; i < bitList.Count(); i++)
            {
                fullSum += (bitList[i] * bitNumerableList[i]);
            }
            sequence = fullSum.ToString();
            return sequence;

        }
        private string convertBaseTwotoSixteen(string num)
        {
            StringBuilder sequence = new StringBuilder();
            sequence.Append("0x ");
            List<string> groupList = new List<string>();
            List<char> charList = new List<char>();
            int digitCount = 0;
            foreach(char c in num)
            {
                digitCount++;
                charList.Add(c);
            }
            //Check if sequence of binary digits is divisible by 4
            while (digitCount % 4 != 0)
            {
                charList.Insert(0,'0');
                digitCount++;
            }
            for (int i = 4; i <= charList.Count(); i += 4) 
            {                                                  
                int jCount = 0;
                StringBuilder group = new StringBuilder();
                for (int j = i - 4; j < i && j >= i - 4; j++)
                {
                    group.Append(charList[j]); 
                    if (jCount == 3)
                    {
                        groupList.Add(group.ToString());
                        break;
                    }
                    jCount++;
                }
            }
            for (int i = 0; i < groupList.Count(); i++)
            {
                switch (groupList[i])
                {
                    case "0000":
                        sequence.Append('0');
                        break;
                    case "0001":
                        sequence.Append('1');
                        break;
                    case "0010":
                        sequence.Append('2');
                        break;
                    case "0011":
                        sequence.Append('3');
                        break;
                    case "0100":
                        sequence.Append('4');
                        break;
                    case "0101":
                        sequence.Append('5');
                        break;
                    case "0110":
                        sequence.Append('6');
                        break;
                    case "0111":
                        sequence.Append('7');
                        break;
                    case "1000":
                        sequence.Append('8');
                        break;
                    case "1001":
                        sequence.Append('9');
                        break;
                    case "1010":
                        sequence.Append('A');
                        break;
                    case "1011":
                        sequence.Append('B');
                        break;
                    case "1100":
                        sequence.Append('C');
                        break;
                    case "1101":
                        sequence.Append('D');
                        break;
                    case "1110":
                        sequence.Append('E');
                        break;
                    case "1111":
                        sequence.Append('F');
                        break;
                }
            }
            return sequence.ToString();
        }
        private string convertBaseSixteentoTen(string num)
        {
            StringBuilder sequence = new StringBuilder();
            List<string> hexDigitList = new List<string>();
            List<double> numList = new List<double>();
            List<long> resultList = new List<long>();
            List<long> powerList = new List<long>();
            long finalResult = 0;
            long powerCount = -1;
            foreach (var c in num)
            {
                hexDigitList.Add(c.ToString());
                powerCount++;
                powerList.Add(powerCount);
            }
            foreach (var c in hexDigitList)
            {
                switch (c)
                {
                    case "A":
                        numList.Add(10);
                        break;
                    case "B":
                        numList.Add(11);
                        break;
                    case "C":
                        numList.Add(12);
                        break;
                    case "D":
                        numList.Add(13);
                        break;
                    case "E":
                        numList.Add(14);
                        break;
                    case "F":
                        numList.Add(15);
                        break;
                    case "a":
                        numList.Add(10);
                        break;
                    case "b":
                        numList.Add(11);
                        break;
                    case "c":
                        numList.Add(12);
                        break;
                    case "d":
                        numList.Add(13);
                        break;
                    case "e":
                        numList.Add(14);
                        break;
                    case "f":
                        numList.Add(15);
                        break;
                    default:
                        numList.Add(Convert.ToInt64(c));
                        break;
                }
            }
            for (int i = 0; i < powerList.Count; i++)
            {
                resultList.Add(Convert.ToInt64(Math.Pow(16, powerList[i])));
            }
            int resultCount = 0;
            for (int i = numList.Count - 1; i > -1; i--)
            {
                finalResult += Convert.ToInt64(numList[i] * resultList[resultCount]);
                resultCount++;
            }
            sequence.Append(finalResult.ToString());
            return sequence.ToString();
        }
        private string convertBaseEighttoTen(string num)
        {
            StringBuilder sequence = new StringBuilder();
            List<string> octalDigitList = new List<string>();
            List<double> numList = new List<double>();
            List<long> resultList = new List<long>();
            List<long> powerList = new List<long>();
            long finalResult = 0;
            long powerCount = -1;
            foreach (var c in num)
            {
                octalDigitList.Add(c.ToString());
                powerCount++;
                powerList.Add(powerCount);
            }
            foreach (var c in octalDigitList)
            {
                numList.Add(Convert.ToInt64(c));
            }
            for (int i = 0; i < powerList.Count; i++)
            {
                resultList.Add(Convert.ToInt64(Math.Pow(8, powerList[i])));
            }
            int resultCount = 0;
            for (int i = numList.Count - 1; i > -1; i--)
            {
                finalResult += Convert.ToInt64(numList[i] * resultList[resultCount]);
                resultCount++;
            }
            sequence.Append(finalResult.ToString());
            return sequence.ToString();
        }

    }
}
