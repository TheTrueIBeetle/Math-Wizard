using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Converters;
using DSharpPlus.CommandsNext.Entities;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBotv2.Commands
{
    public class CustomHelpFormatter : DefaultHelpFormatter
    {
        public CustomHelpFormatter(CommandContext ctx): base(ctx) { }
        public override CommandHelpMessage Build()
        {
            EmbedBuilder.Color = DiscordColor.Purple;
            return base.Build();
        }
    }
}
