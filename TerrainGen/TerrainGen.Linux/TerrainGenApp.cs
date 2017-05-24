using SiliconStudio.Xenko.Engine;

namespace TerrainGen
{
    class TerrainGenApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
