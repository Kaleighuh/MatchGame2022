using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public IDObj IDs;
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
            Debug.Log("Matched");
        }
        else
        {
            {
                Debug.Log("No Match");
            }
        }
    }
}
