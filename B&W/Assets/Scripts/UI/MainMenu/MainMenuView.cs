using System;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuView : MonoBehaviour, IView
{
    [SerializeField] MainMenuScriptableObject _mainMenuData;

    private MainMenuController _controller;

    public List<Action> Actions => throw new NotImplementedException();

    private void OnEnable()
    {
        _controller = new(this, _mainMenuData);
    }
}
