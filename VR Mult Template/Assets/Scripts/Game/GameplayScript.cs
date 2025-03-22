using UnityEngine;

public class GameplayScript : MonoBehaviour
{
    public int score1 = 0;
    public int score2 = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DisplayScores()
    {
        Debug.Log("Team 1: " + score1 + " | Team 2: " + score2);
    }
}
