using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour, IView
{
    public MainMenuScriptableObject MainMenuData {  get; private set; }
    public Button ContinueGameButton { get; private set; }
    public Button StartGameButton { get; private set; }
    public Button SettingsButton { get; private set; }
    public Button ExitGameButton { get; private set; }
    public Canvas MainMenuCanvas { get; private set; }
    public Canvas SettingsCanvas { get; private set; }

    private MainMenuController _controller;

    public List<Action> Actions => throw new NotImplementedException();

    private void OnEnable()
    {
        _controller = new(this, MainMenuData);
    }

    private void OnDestroy()
    {
        _controller.Dispose();

        _controller = null;
    }
}
