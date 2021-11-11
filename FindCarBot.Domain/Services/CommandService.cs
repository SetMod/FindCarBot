using System.Collections.Generic;
using FindCarBot.Domain.Abstractions;
using FindCarBot.Domain.Commands;

namespace FindCarBot.Domain.Services
{
    public class CommandService: ICommandService
    {
        private readonly List<TelegramCommand> _commands;

        public CommandService()
        {
            _commands = new List<TelegramCommand>
            {
                new HelpCommand(),
                new MainCommand(),
                new StartCommand()
            };
        }

        public List<TelegramCommand> Get() => _commands;
    }
}