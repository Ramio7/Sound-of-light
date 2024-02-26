using UnityEngine;

public class EntryPointController : BaseController
{
    private new EntryPointModel _model;

    public EntryPointController(EntryPointView view, EntryPointScriptableObject modelData) : base(view)
    {
        _model = new EntryPointModel(modelData);
        Init();
    }

    public override void Init()
    {
        InstantiateMainMenu(_model.MainMenuView);
        InstantiateGame(_model.GameView);
    }

    private void InstantiateMainMenu(GameObject mainMenuPrefab) => InstantiateChildObject(mainMenuPrefab);
    private void InstantiateGame(GameObject gamePrefab) => InstantiateChildObject(gamePrefab);
}
