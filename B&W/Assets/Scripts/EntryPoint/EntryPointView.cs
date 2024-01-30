using System;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointView : MonoBehaviour, IView
{
    [SerializeField] private IScriptableObject _mainMenuData;

    EntryPointController _controller;

    public List<Action> Actions => throw new NotImplementedException();

    private void OnEnable()
    {
        _controller = new(this, _mainMenuData);
    }
}
