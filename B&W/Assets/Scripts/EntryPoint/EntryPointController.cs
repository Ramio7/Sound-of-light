using UnityEngine;

public class EntryPointController : BaseController
{
    public EntryPointController(EntryPointView view, EntryPointScriptableObject modelData) : base(view)
    {
        var tempModel = new EntryPointModel(modelData);
        InstantiateMainMenu(tempModel.MainMenuPrefab);
    }

    private void InstantiateGameService(GameObject serviceObjectPrefab) => Object.Instantiate(serviceObjectPrefab);

    private void InstantiateMainMenu(GameObject mainMenuPrefab) => InstantiateGameService(mainMenuPrefab);
}
