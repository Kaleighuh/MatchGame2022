using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public IDObj IDs;
    public UnityEvent matchEvent, noMatchEvent;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(IDs);
        //Debug.Log(other.GetComponent<IDContainer>().IDs);
        var tempObj= other.GetComponent<IDContainer>();
        if (tempObj != null)
            return;
        var otherID = tempObj.IDs;
        if (otherID == IDs)
        {
            matchEvent.Invoke();
        }
        else
        {
            {
                noMatchEvent.Invoke();
            }
        }
    }
}
