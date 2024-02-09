using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/" + nameof(EntryPointScriptableObject), fileName = nameof(EntryPointScriptableObject))]
public class EntryPointScriptableObject : BaseScriptableObject
{
    public GameObject MainMenuObject { get; private set; }
}
