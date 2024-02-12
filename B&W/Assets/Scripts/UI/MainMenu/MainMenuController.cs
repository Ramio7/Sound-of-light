public class MainMenuController : BaseController
{
    private new MainMenuModel _model;
    private new MainMenuView _view;

    public MainMenuController(MainMenuView view, MainMenuScriptableObject modelData) : base(view)
    {
        _model = new MainMenuModel(modelData);
        _view = view;
    }

    public override void Init()
    {
        
    }

    public override void Dispose()
    {
        _model.Dispose();

        _model = null;
        _view = null;
    }
}
