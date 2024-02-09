using System;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointView : MonoBehaviour, IView
{
    public EntryPointScriptableObject EntryPointData { get; private set; }

    private EntryPointController _controller;

    public List<Action> Actions => throw new NotImplementedException();

    public static event Action OnUpdate;
    public static event Action OnFixedUpdate;

    private void Awake()
    {
        OnUpdate = Update;
        OnFixedUpdate = FixedUpdate;
    }

    private void OnEnable()
    {
        DontDestroyOnLoad(this);
        _controller = new(this, EntryPointData);
    }

    private void Update()
    {
        OnUpdate.Invoke();

        if (Input.GetKeyUp(KeyCode.Escape))
        {
#if UNITY_EDITOR
            Debug.Break();
#else
            Application.Quit();
#endif
        }
    }

    private void FixedUpdate() 
    {
        OnFixedUpdate.Invoke();
    }

    private void OnDestroy()
    {
        DisposeController();
    }

    private void DisposeController()
    {
        _controller.Dispose();
        _controller = null;
    }
}
