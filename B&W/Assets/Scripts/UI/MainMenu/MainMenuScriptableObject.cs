using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/" + nameof(MainMenuScriptableObject), fileName = nameof(MainMenuScriptableObject))]
public class MainMenuScriptableObject : BaseScriptableObject
{
    public GameObject MainMenuPrefab { get; private set; }
}
