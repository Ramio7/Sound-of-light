using UnityEngine;

public class EntryPointController : BaseController
{
    private new EntryPointModel _model;

    public EntryPointController(EntryPointView view, EntryPointScriptableObject modelData) : base(view)
    {
        var tempModel = new EntryPointModel(modelData);
        Init();
    }

    public override void Init()
    {
        InstantiateMainMenu(_model.MainMenuView);
    }

    private void InstantiateMainMenu(GameObject mainMenuPrefab) => InstantiateChildObject(mainMenuPrefab);
}
