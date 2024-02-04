using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discordBot.commands
{
    internal class TestCommands : BaseCommandModule
    {
        [Command("test")]
        public async Task FirstCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("hello");
        }
    }
}
