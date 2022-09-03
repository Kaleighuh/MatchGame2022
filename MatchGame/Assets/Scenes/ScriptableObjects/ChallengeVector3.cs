using UnityEngine;

[CreateAssetMenu]
public class ChallengeVector3 : ScriptableObject
{
    public string name = "Vector 3 Scriptable Object";
    public Vector3[] powerupSpawn;
    private void OnTriggerEnter(Collider Other)
    {
        triggerEnterEvent.Invoke();
    } //Anthony Romrell lectures
}
