using UnityEngine.UI;

public class MainMenuModel : BaseModel
{
    public Button ContinueGameButton { get; private set; }
    public Button StartGameButton { get; private set; }
    public Button SettingsButton { get; private set; }
    public Button ExitGameButton { get; private set; }

    public MainMenuModel(MainMenuScriptableObject data) : base()
    {
        ContinueGameButton = data.ContinueGameButton;
        StartGameButton = data.StartGameButton;
        SettingsButton = data.SettingsButton;
        ExitGameButton = data.ExitGameButton;
    }

    public override void Dispose()
    {
        ContinueGameButton = null;
        StartGameButton = null;
        SettingsButton = null;
        ExitGameButton = null;
    }
}
