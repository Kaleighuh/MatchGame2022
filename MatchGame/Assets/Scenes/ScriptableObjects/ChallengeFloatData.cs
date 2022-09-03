using UnityEngine;

//Code from Anthony Romrell
//Supposed to be a health script
[CreateAssetMenu(fileName = "FloatPracice", menuName = "Practice")]
public class ChallengeFloatData : ScriptableObject
{
    public int value; //health
    public void UpdateValue(int number);
    {
        value += number;
    }

}
