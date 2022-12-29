using System;
using System.Reflection.Metadata;

var commandConsumer = new CommandHandler();

// Add your commands to the command consumer
//commandConsumer.AddCommand(new Command("select", SelectTileObject));
//commandConsumer.AddCommand(new Command("deselect", DeselectTileObject));
//commandConsumer.AddCommand(new Command("move", MoveTileObject));
//Console.Write(" [testTileObject]  ");


// Add your commands to the command consumer
commandConsumer.AddCommand(new Command("select", commandName => SelectTileObject(commandName)));
commandConsumer.AddCommand(new Command("deselect", commandName => DeselectTileObject(commandName)));
commandConsumer.AddCommand(new Command("move", commandName => MoveTileObject(commandName)));
while (true)
{
    ExecuteCommands(commandConsumer);
}

///<summary>
///Parse the arguments to get the x and y position and Selecting the tile object at the given position and show the available movement positions
/// </summary> 
static void ExecuteCommands(CommandHandler commandConsumer)
{
        // Read the next key press
        var key = Console.ReadKey();

        // Check if the key press is a valid command
        if (key.Key == ConsoleKey.S)
        {
            commandConsumer.ProcessCommand("select");
        }
        else if (key.Key == ConsoleKey.D)
        {
            commandConsumer.ProcessCommand("deselect");
        }
        else if (key.Key == ConsoleKey.M)
        {
            commandConsumer.ProcessCommand("move");
        }
}


static void SelectTileObject(string commandName) { }
static void MoveTileObject(string commandName) { }
static void DeselectTileObject(string commandName) { }







