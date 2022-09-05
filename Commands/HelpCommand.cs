/* File Name: HelpCommand.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Last Date Published: Jan. 31 2021
 */

using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBotv2.Commands
{
    public class HelpCommand : BaseCommandModule
    {

        [Command("commands")]
        [Aliases("cmds","cmd","command")]
        [Description("Gives a list of commands")]
        public async Task Help(CommandContext ctx)
        {
            var helpEmbed1 = new DiscordEmbedBuilder
            {
                Title = "List Of Commands Page",
                Color = DiscordColor.Purple,
                Description = "Use 'm.help <command name>' to get a description of the command. 'm.' is " +
                "the prefix for all commands"
                
            };
           
            helpEmbed1.AddField("Utilitarian", "help\ncommands/cmd/cmds");
            helpEmbed1.AddField("Operations","add\nsubtract\nmultiply\ndivide\nmod\npower\nsqrt" +
                "\ncbrt\nfloor\nceiling\nround\nnthrt\nfactorial");
            helpEmbed1.AddField("Statistical", "mean\nmedian\nmode\nvariance\nstandarddevi\nmeandevi" +
                "\nmediandevi\nmin\nmax\nsum\nprimefactors");
            helpEmbed1.AddField("Base Conversions", "base10to2 (Decimal to Binary)\nbase10to16 (Decimal to Hexadecimal)" +
                "\nbase10to8 (Decimal to Octal)\nbase2to10 (Binary to Decimal)\nbase2to16 (Binary to Hexadecimal)" +
                "\nbase2to8 (Binary to Octal)\nbase16to10 (Hexadecimal to Decimal)\nbase16to2 (Hexadecimal to Binary)" +
                "\nbase16to8 (Hexadecimal to Octal)\nbase8to10 (Octal to Decimal)\nbase8to2 (Octal to Binary)\nbase8to16 (Octal to Hexadecimal)");
            /*helpEmbed1.AddField("2D Geometrical", "areacircle\ncircumference\ndiametercircle\narearectangle\nperimeterrectangle\ndiagonalrectangle" +
                "\narearhombus\nperimeterrhombus\nareatrapezoid\nperimetertrapezoid\nareapentagon\nperimeterpentagon" +
                "\nareahexagon\nperimeterhexagon\nareaheptagon\nperimeterheptagon\nareaoctagon\nperimeteroctagon\nareanonagon\nperimeternonagon" 
                + "\n");*/
            helpEmbed1.AddField("2D Geometrical", "areacircle\narearectangle\narearhombus\nareatrapezoid\nareapentagon\nareahexagon\nareaheptagon" +
                "\nareaoctagon\nareanonagon\ncircumference\nperimeterrectangle\nperimeterrhombus\nperimetertrapezoid\nperimeterpentagon" +
                "\nperimeterhexagon\nperimeterheptagon\nperimeteroctagon\nperimeternonagon\ndiametercircle\ndiagonalrectangle");
            /* helpEmbed1.AddField("3D Geometrical", "areasphere\nvolumesphere\narearecprism\nvolumerecprism\nareacylinder" +
                 "\nvolumecylinder\nareacone\nvolumecone\nslantcone\nareatetrahedron\nvolumetetrahedron\nareatorus" + 
                 "\nvolumetorus");*/
            helpEmbed1.AddField("3D Geometrical", "areasphere\narearecprism\nareacylinder\nareacone\nareatetrahedron\nareatorus" +
                "\narearecpyramid\nvolumesphere\nvolumerecprism\nvolumecylinder\nvolumecone\nvolumetetrahedron" +
                "\nvolumetorus\nvolumerecpyramid\nslantcone");
            helpEmbed1.AddField("Trig", "sin\ncos\ntan\nsinh\ncosh\ntanh\nasin\nacos\natan\nperimetertriangle\nareatriangle");

            var message = await ctx.Member.SendMessageAsync(embed: helpEmbed1).ConfigureAwait(false);

        }
    }
}
