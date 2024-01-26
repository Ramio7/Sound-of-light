using System;

public interface IController: IDisposable
{
    void Init(IView view, IModel model);
}
