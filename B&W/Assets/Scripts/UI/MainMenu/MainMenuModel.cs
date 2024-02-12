using UnityEngine;

public class MainMenuModel : BaseModel
{
    private Canvas _activeCanvas;

    public MainMenuModel(MainMenuScriptableObject data) : base()
    {
        
    }

    public override void Dispose()
    {
        _activeCanvas = null;
    }

    public void ChangeCanvas(Canvas canvasToActivate)
    {
        _activeCanvas.enabled = false;
        _activeCanvas = canvasToActivate;
    }
}
