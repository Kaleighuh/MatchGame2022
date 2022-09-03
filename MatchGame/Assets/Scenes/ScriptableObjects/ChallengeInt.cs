using UnityEngine;

[CreateAssetMenu]
public class ChallengeInt : ScriptableObject
{
    public int manaCost;
    public int attackDamage;
    
    public void UpdateValue(int num)
    {
        value += num;
    }
}
