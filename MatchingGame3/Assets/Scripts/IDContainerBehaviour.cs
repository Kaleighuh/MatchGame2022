using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehaviour : MonoBehaviour
{
    public ID IDs;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }

}
