using System.IO;
using System.Text;
using UnityEngine;

public class SettingsMenuModel : BaseModel
{
    private float _soundVolume;
    private float _musicVolume;
    private float _brightnessVolume;

    private string _settingsFilePath = Path.Combine(Application.dataPath, "/Resources/settings.json");

    public SettingsMenuModel(SettingsMenuScriptableObject defaults) : base()
    {
        if (!CheckSettingsFile(_settingsFilePath))
        {
            _soundVolume = defaults.DefaultSoundVolume;
            _musicVolume = defaults.DefaultMusicVolume;
            _brightnessVolume = defaults.DefaultBrightnessVolume;
            CreateSettingsFile(_settingsFilePath);
        }
        else
        {
            LoadSettings(_settingsFilePath);
        }
    }

    public override void Dispose()
    {
        _soundVolume = 0;
        _musicVolume = 0;
        _brightnessVolume = 0;
    }

    private bool CheckSettingsFile(string path) => File.Exists(path);

    private void CreateSettingsFile(string path)
    {
        var fileStream = new FileStream(path, FileMode.CreateNew);
        var dataToWrite = $"{_soundVolume.GetType().Name}: {_soundVolume}\n" +
            $"{_musicVolume.GetType().Name}: {_musicVolume}\n" +
            $"{_brightnessVolume.GetType().Name}: {_brightnessVolume}";
        var stringToByteArray = Encoding.ASCII.GetBytes(dataToWrite.ToCharArray());
        fileStream.Write(stringToByteArray);
        fileStream.Close();
    }

    private void LoadSettings(string path)
    {
        
    }

    public void ChangeSoundVolume(float volume) => _soundVolume = volume;
    public void ChangeMusicVolume(float volume) => _musicVolume = volume;
    public void ChangeBrightnessVolume(float volume) => _brightnessVolume = volume;
}
