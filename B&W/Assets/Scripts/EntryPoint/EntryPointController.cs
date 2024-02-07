using UnityEngine;

public class EntryPointController : BaseController
{
    public EntryPointController(EntryPointView view, EntryPointScriptableObject modelData) : base(view)
    {
        var tempModel = new EntryPointModel(modelData);
        InstantiateMainMenu(tempModel.MainMenuView);
    }

    private void InstantiateMainMenu(GameObject mainMenuPrefab) => InstantiateChildObject(mainMenuPrefab);
}
