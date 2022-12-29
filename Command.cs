using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Command
{
    public string Name { get; set; }
    public Action<string> CommandAction { get; set; }

    public Command(string name, Action<string> commandAction)
    {
        Name = name;
        CommandAction = commandAction;
    }
}