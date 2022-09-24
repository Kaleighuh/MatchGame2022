using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    public UnityEvent destroyEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void Disable()
    {
        disableEvent.Invoke();
    }
    
    private void onDestroy()
    {
        destroyEvent.Invoke();
    }
    
}
