using System;
using System.Collections.Generic;

public interface IModel : IInitiable, IDisposable
{
    List<object> Methods { get; }
}
