/* File Name: TrigonometryCommands.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Last Date Published: Feb. 25 2021
 */
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBotv2.Commands
{
    public sealed class TrigonometryCommands : BaseCommandModule
    {
        [Command("Sin")]
        [Description("Finds the sine of a given angle")]
        public async Task Sin(CommandContext ctx, [Description("Angle")]double angle)
        {
            await ctx.Channel.SendMessageAsync(findSine(angle).ToString()).ConfigureAwait(false);
        }

        [Command("Cos")] 
        [Description("Finds the cosine of a given angle")]
        public async Task Cos(CommandContext ctx, [Description("Angle")]double angle)
        {
            await ctx.Channel.SendMessageAsync(findCosine(angle).ToString()).ConfigureAwait(false);
        }

        [Command("Tan")]
        [Description("Finds the tangent of a given angle")]
        public async Task Tan(CommandContext ctx, [Description("Angle")]double angle)
        {
            await ctx.Channel.SendMessageAsync(findTangent(angle).ToString()).ConfigureAwait(false);
        }

        [Command("Sinh")]
        [Description("Finds the hyperbolic sine of a given angle")]
        public async Task Sinh(CommandContext ctx, [Description("Angle")] double angle)
        {
            await ctx.Channel.SendMessageAsync(findHyperbolicSine(angle).ToString()).ConfigureAwait(false);
        }

        [Command("Cosh")]
        [Description("Finds the hyperbolic cosine of a given angle")]
        public async Task Cosh(CommandContext ctx, [Description("Angle")] double angle)
        {
            await ctx.Channel.SendMessageAsync(findHyperbolicCosine(angle).ToString()).ConfigureAwait(false);
        }

        [Command("Tanh")]
        [Description("Finds the hyperbolic tangent of a given angle")]
        public async Task Tanh(CommandContext ctx, [Description("Angle")] double angle)
        {
            await ctx.Channel.SendMessageAsync(findHyperbolicTangent(angle).ToString()).ConfigureAwait(false);
        }

        [Command("Asin")]
        [Description("Finds the angle of a given sine")]
        public async Task Asine(CommandContext ctx, [Description("Sine")] double angle)
        {
            //await ctx.Channel.SendMessageAsync(findAngleOfSine(angle).ToString() + " degrees").ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync("This command is currently out of commission for bug fixes. Sorry for the inconvenience").ConfigureAwait(false);
        }

        [Command("Acos")]
        [Description("Finds the angle of a given cosine")]
        public async Task Acos(CommandContext ctx, [Description("Cosine")] double angle)
        {
            //await ctx.Channel.SendMessageAsync(findAngleOfCosine(angle).ToString() + " degrees").ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync("This command is currently out of commission for bug fixes. Sorry for the inconvenience").ConfigureAwait(false);
        }

        [Command("Atan")]
        [Description("Finds the angle of a given tangent")]
        public async Task Atan(CommandContext ctx, [Description("Tangent")] double angle)
        {
            //await ctx.Channel.SendMessageAsync(findAngleOfTan(angle).ToString() + " degrees").ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync("This command is currently out of commission for bug fixes. Sorry for the inconvenience").ConfigureAwait(false);
        }

        [Command("AreaTriangle")]
        [Description("Finds the total surface area of a triangle with the given base and height")]
        public async Task AreaTriangle(CommandContext ctx, [Description("Base")] decimal bbase, [Description("Height")]
        decimal height)
        {
            await ctx.Channel.SendMessageAsync(findAreaTriangle(bbase, height).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterTriangle")]
        [Description("Finds the total perimeter of a triangle with the given base and two sides")]
        public async Task PerimeterTriangle(CommandContext ctx, [Description("Base")] decimal bbase,
            [Description("Side 1")] decimal side1, [Description("Side 2")] decimal side2)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterTriangle(bbase, side1, side2).ToString()).ConfigureAwait(false);
        }



        //Helper Methods
        private double findSine(double angle)
        {
            return Math.Sin(angle);
        }
        private double findCosine(double angle)
        {
            return Math.Cos(angle);
        }
        private double findTangent(double angle)
        {
            return Math.Tan(angle);
        }
        private double findHyperbolicSine(double angle)
        {
            return Math.Sinh(angle);
        }
        private double findHyperbolicCosine(double angle)
        {
            return Math.Cosh(angle);
        }
        private double findHyperbolicTangent(double angle)
        {
            return Math.Tanh(angle);
        }
        private double findAngleOfSine(double angle)
        {
            return Math.Asin(angle);
        }
        private double findAngleOfCosine(double angle)
        {
            return Math.Acos(angle);
        }
        private double findAngleOfTan(double angle)
        {
            return Math.Atan(angle);
        }
        private decimal findAreaTriangle(decimal bbase, decimal height)
        {
            return (height * bbase) / 2;
        }
        private decimal findPerimeterTriangle(decimal bbase, decimal side1, decimal side2)
        {
            return bbase + side1 + side2;
        }
    }
}
