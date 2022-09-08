using UnityEngine.Events;
using UnityEngine;

public class PracticeMonoBehaviours : MonoBehaviour
{
    private float moveVelocity;
    public float speed;


    public UnityEvent fastEvent, slowEvent;
    private void start()
    {
        startEvent.Invoke();
    }
    private void fast()
    {
        fastEvent.Invoke();
        if(Input.powerUp)
        {
            moveVelocity = speed;
        }
    }
    private void Slow()
    {
        slowEvent.Invoke();
        if(Input.powerDown)
        {
            moveVelocity = -speed;
        }
    }

}
