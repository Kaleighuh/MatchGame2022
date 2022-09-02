using UnityEngine;
using UnityEngine.Events;
public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider Other)
    {
        triggerEnterEvent.Invoke();
    }
}
