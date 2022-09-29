using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameActions : ScriptableObject
{ 
    public UnityAction raise;

    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
