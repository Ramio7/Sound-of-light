using UnityEngine;

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
        SubscribeButtons();
    }

    public override void Dispose()
    {
        _model.Dispose();

        _model = null;
        _view = null;
    }

    private void SubscribeButtons()
    {
        _view.SettingsButton.onClick.AddListener(ActivateSettingsMenu);
#if UNITY_EDITOR
        _view.ExitGameButton.onClick.AddListener(Debug.Break);
#else
        _view.ExitGameButton.onClick.AddListener(Application.Quit);
#endif
        _view.ContinueGameButton.onClick.AddListener(GameController.Instance.StartGame);
        _view.StartGameButton.onClick.AddListener(GameController.Instance.StartGame);
    }

    private void ActivateSettingsMenu() => _model.ChangeCanvas(_view.SettingsCanvas);
}
