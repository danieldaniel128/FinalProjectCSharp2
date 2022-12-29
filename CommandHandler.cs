using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CommandHandler
{
    private readonly List<Command> _commands = new List<Command>();

    public void AddCommand(Command command)
    {
        _commands.Add(command);
    }

    public void ProcessCommand(string input)
    {
        // Find the command with the matching name
        var command = _commands.FirstOrDefault(c => c.Name == input);
        if (command == null)
        {
            Console.WriteLine("Invalid command");
            return;
        }

        // Execute the command
        command.CommandAction(input);
    }
}