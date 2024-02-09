using System;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuView : MonoBehaviour, IView
{
    public MainMenuScriptableObject MainMenuData {  get; private set; }

    private MainMenuController _controller;

    public List<Action> Actions => throw new NotImplementedException();

    private void OnEnable()
    {
        _controller = new(this, MainMenuData);
    }
}
