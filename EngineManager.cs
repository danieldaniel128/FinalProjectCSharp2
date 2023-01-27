using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class EngineManager// : Engine???
{

    public UpgradedTileMap Grid { get; set; }//private set or method that will set differently, maybe only private and will get access only through Tilemap???
    

    public EngineManager(UpgradedTileMap tileMap)
    {
        Grid = tileMap;
    }

    public bool IsRunning { get; private set; }//get is private too?






    public void Pause()
    {
        IsRunning = !IsRunning;
    }

    public void GameLoop() 
    {
        Grid.ChangeGridToChessGrid('7', ConsoleColor.Red);
        while (IsRunning) 
        {
            Console.Clear();
            Grid.DrawGrid();
            Thread.Sleep(500);
        }
    }








}
