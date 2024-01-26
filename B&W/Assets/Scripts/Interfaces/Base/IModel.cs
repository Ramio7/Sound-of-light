using System;
using UnityEngine;

public interface IModel : IDisposable
{
    void Init(ScriptableObject modelData);
}
