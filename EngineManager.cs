using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EngineManager
{
    public EngineManager()
    {

    }

    public bool IsRunning { get; set; }






    public void Pause()
    {
        IsRunning = !IsRunning;
    }

    public void GameLoop() 
    {
        while (IsRunning) 
        {

            Thread.Sleep(1000);
        }
    }








}
