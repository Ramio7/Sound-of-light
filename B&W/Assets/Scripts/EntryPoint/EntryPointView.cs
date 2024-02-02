using System;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointView : MonoBehaviour, IView
{
    [SerializeField] private EntryPointScriptableObject _entryPointData;

    EntryPointController _controller;

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
        _controller = new(this, _entryPointData);
        Instantiate(_entryPointData._mainMenuPrefab);
    }

    private void Update()
    {
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
        
    }

    private void OnDestroy()
    {
        DisposeControllers();
    }

    private void DisposeControllers()
    {
        _controller.Dispose();
        _controller = null;
    }
}
