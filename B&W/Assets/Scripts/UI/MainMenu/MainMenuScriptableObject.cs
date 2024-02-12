using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObjects/" + nameof(MainMenuScriptableObject), fileName = nameof(MainMenuScriptableObject))]
public class MainMenuScriptableObject : BaseScriptableObject
{
    public GameObject MainMenuPrefab { get; private set; }
    public Button ContinueGameButton { get; private set; }
    public Button StartGameButton { get; private set; }
    public Button SettingsButton { get; private set; }
    public Button ExitGameButton { get; private set; }
}
