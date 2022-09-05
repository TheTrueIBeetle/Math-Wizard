/* File Name: Bot.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Date Started: Sep. 15 2020
 * Last Date Published: March. 20, 2021
 * Version: 1.2.0-beta
 */

using CSharpBotv2.Commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.Entities;
using System.Runtime.InteropServices.ComTypes;
using DSharpPlus.CommandsNext.Entities;
using DSharpPlus.CommandsNext.Builders;
using DSharpPlus.CommandsNext.Converters;
using Microsoft.Extensions.DependencyInjection;

namespace CSharpBotv2
{
    class Bot
    {
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension All_Commands { get; private set; }
        public DiscordActivity Status { get; private set; }
        
        public async Task RunAsync()
        {
            try
            {

                var json = string.Empty;
                using (var fs = File.OpenRead("config.json"))
                using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                    json = await sr.ReadToEndAsync().ConfigureAwait(false);

                var Configjson = JsonConvert.DeserializeObject<Configjson>(json);

                var config = new DiscordConfiguration
                {
                    Token = Configjson.Token,
                    TokenType = TokenType.Bot,
                    AutoReconnect = true,
                    LogLevel = LogLevel.Debug,
                    HttpTimeout = System.Threading.Timeout.InfiniteTimeSpan,
                    UseInternalLogHandler = true
                };

                //Put back here
                Client = new DiscordClient(config);
                Client.Ready += OnClientReady;

                var commandsConfig = new CommandsNextConfiguration
                {
                    StringPrefixes = new string[] { Configjson.Prefix },
                    EnableDms = false,
                    EnableMentionPrefix = true,
                    DmHelp = true,
                    //Services = new ServiceCollection().BuildServiceProvider(true)
                    
                };
                All_Commands = Client.UseCommandsNext(commandsConfig);

                //Register the commands 
                All_Commands.RegisterCommands<OperationCommands>();
                All_Commands.RegisterCommands<StatisticalCommands>();
                All_Commands.RegisterCommands<ConversionCommands>();
                All_Commands.RegisterCommands<HelpCommand>();
                All_Commands.RegisterCommands<GeometryCommands>();
                All_Commands.RegisterCommands<TrigonometryCommands>();
                All_Commands.SetHelpFormatter<CustomHelpFormatter>();



                await Client.ConnectAsync();


                await Task.Delay(-1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was some kind of error: " + ex.Message);
            }
            

        }

        //Class Functions
        private Task OnClientReady(ReadyEventArgs e)
        {
            DateTime now = DateTime.Now;

            DiscordActivity stat = new DiscordActivity("m.cmds | m.help | Version: 1.2.0-beta" /*Active since: " + now.ToString("F")*/, ActivityType.Playing);
            Client.UpdateStatusAsync(stat);
            return Task.CompletedTask;
        }
    }
}
