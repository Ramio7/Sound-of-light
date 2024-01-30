public class BaseController : IController
{
    private IView _view;
    private IModel _model;

    public BaseController(IView view, IScriptableObject modelData)
    {
        _model = new BaseModel(modelData);
        _view = view;
    }

    public virtual void Init()
    {
        _model.Init();
    }

    public void Dispose()
    {
        _model.Dispose();

        _model = null;
        _view = null;
    }
}
