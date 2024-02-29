using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuView : MonoBehaviour, IView
{
    [SerializeField] private SettingsMenuScriptableObject _settingsDefaults;

    [SerializeField] private Slider _soundVolumeSlider;
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _brightnessVolumeSlider;

    private SettingsMenuController _controller;

    public List<Action> Actions => throw new NotImplementedException();

    private void OnEnable()
    {
        _controller = new(this, _settingsDefaults);
    }

    private void OnDestroy()
    {
        _controller.Dispose();

        _controller = null;
    }
}
