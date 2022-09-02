using UnityEngine;

[CreateAssetMenu]
public class Float : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
}
