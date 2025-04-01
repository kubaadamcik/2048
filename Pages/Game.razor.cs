using Hra2048.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Hra2048.Pages;

public partial class Game : ComponentBase
{
    [Inject] public NavigationManager NavigationManager { get; set; }

    public GameModel GameModel = new GameModel();

    public Game(NavigationManager navigationManager)
    {
        NavigationManager = navigationManager;
    }
    
    
}