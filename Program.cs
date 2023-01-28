using FinalProjectCSharp2;

class Program
{

    public static void Main(string[] args)
    {
        //VectorTesting vectorTesting = new VectorTesting();

        //VectorTesting.Test();
        UpgradedTileMap tiles = new UpgradedTileMap(5,6);
        EngineManager engineManager =new EngineManager(tiles);
        TileObjectExample tileObj = new TileObjectExample();
       tileObj.Something();

     
        //engineManager.Pause();


        //tiles.FillSpiralMatrix();
        //engineManager.GameLoop();
       



       
    }
}












