using UnityEngine;

public class BaseController : IController
{
    private IView _view;
    private IModel _model;

    public BaseController(IView view, ScriptableObject modelData)
    {
        _model = new BaseModel(modelData);
        _view = view;
    }

    public virtual void Init()
    {
        _model.Init();

        var _methodsAsObjects = _model.Methods.ToArray();
        var _actions = _view.Actions.ToArray();

        for (int i = 0; i < _view.Actions.Count; i++)
        {
            _actions[i] += (System.Action)_methodsAsObjects[i];
        }
    }

    public void Dispose()
    {
        _model.Dispose();

        _model = null;
        _view = null;
    }
}
