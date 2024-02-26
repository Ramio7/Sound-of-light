using System;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour, IView
{
    [SerializeField] private GameScriptableObject _gameScriptableObject;

    private GameController _controller;

    public Canvas GameLoaderCanvas {  get; private set; }

    public List<Action> Actions => throw new NotImplementedException();

    private void OnEnable()
    {
        _controller = new(this, _gameScriptableObject);
    }
}
