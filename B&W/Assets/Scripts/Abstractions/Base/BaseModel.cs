using System.Collections.Generic;
using UnityEngine;

public class BaseModel : IModel
{
    private ScriptableObject _modelData;
    private List<int> _values = new();

    public List<object> Methods { get; private set; }

    public BaseModel(ScriptableObject modelData)
    {
        _modelData = modelData;
    }

    public virtual void Init() 
    {
        var _properties = _modelData.GetType().GetProperties();
        
        for (int i = 0; i < _properties.Length; i++)
        {
            ;
        }
    }

    public void Dispose()
    {
        _modelData = null;
    }
}
