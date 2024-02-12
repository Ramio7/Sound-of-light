using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/" + nameof(MainMenuScriptableObject), fileName = nameof(MainMenuScriptableObject))]
public class MainMenuScriptableObject : BaseScriptableObject
{
    public MainMenuView MainMenuPrefab { get; private set; }
}
