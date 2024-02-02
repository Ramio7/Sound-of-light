using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/" + nameof(EntryPointScriptableObject), fileName = nameof(EntryPointScriptableObject))]
public class EntryPointScriptableObject : BaseScriptableObject, IScriptableObject
{
    public GameObject _mainMenuPrefab;
}
