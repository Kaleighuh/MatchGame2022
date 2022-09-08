using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;
    // Start is called before the first frame update
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void start()
    {
        startEvent.Invoke();
    }

    private void onDisable()
    {
        disableEvent.Invoke();
    }
}
