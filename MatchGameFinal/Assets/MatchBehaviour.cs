using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public IDObj IDs;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        //Debug.Log(IDs);
        //Debug.Log(other.GetComponent<IDContainer>().IDs);
        var tempObj= other.GetComponent<IDContainer>();
        if (tempObj != null)
            yield break;
        var otherID = tempObj.IDs;
        if (otherID == IDs)
        {
            matchEvent.Invoke();
        }
        else
        {
            {
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(.5f);
                noMatchDelayEvent.Invoke();
            }
        }
    }
}
