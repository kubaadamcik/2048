namespace Hra2048.Data;

public class GameModel
{
    public int GridSize { get; set; } = 0;
    public int[,] Tiles { get; set; }

    public GameModel()
    {
        Tiles = new int[GridSize, GridSize];
    }

    public GameModel(int size)
    {
        GridSize = size;
        Tiles = new int[GridSize, GridSize];
    }
    
    public void MakeMove()
    {
        
    }
}