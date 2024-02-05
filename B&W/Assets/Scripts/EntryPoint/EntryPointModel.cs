using UnityEngine;

public class EntryPointModel : BaseModel
{
    public GameObject MainMenuPrefab { get; private set; }

    public EntryPointModel(EntryPointScriptableObject modelData) : base()
    {
        Init(modelData);
    }

    protected override void Init(IScriptableObject modelData)
    {
        var tempData = modelData as EntryPointScriptableObject;
        MainMenuPrefab = tempData._mainMenuPrefab;
    }

    public override void Dispose()
    {
        MainMenuPrefab = null;
    }
}
