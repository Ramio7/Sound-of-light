using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/" + nameof(SettingsMenuScriptableObject), fileName = nameof(SettingsMenuScriptableObject))]
public class SettingsMenuScriptableObject : BaseScriptableObject
{
    [SerializeField, Range(0f, 100f)] private float _defaultSoundVolume;
    [SerializeField, Range(0f, 100f)] private float _defaultMusicVolume;
    [SerializeField, Range(0f, 100f)] private float _defaultBrightnessVolume;

    public float DefaultSoundVolume { get => _defaultSoundVolume; }
    public float DefaultMusicVolume { get => _defaultMusicVolume; }
    public float DefaultBrightnessVolume { get => _defaultBrightnessVolume; }
}
