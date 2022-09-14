using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public IDObj IDs;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(IDs);
    }
}
