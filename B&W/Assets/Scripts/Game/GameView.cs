using System;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour, IView
{
    public Canvas GameLoaderCanvas {  get; private set; }

    public List<Action> Actions => throw new NotImplementedException();
}
