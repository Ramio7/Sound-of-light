public class MainMenuController : BaseController
{
    public MainMenuController(MainMenuView view, MainMenuScriptableObject modelData) : base(view)
    {
        var tempModel = new MainMenuModel(modelData);
    }
}
