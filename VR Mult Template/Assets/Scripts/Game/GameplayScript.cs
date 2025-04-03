using UnityEngine;

public class GameplayScript : MonoBehaviour
{
    public int score1;
    public int score2;
    void Start()
    {
        score1 = 0;
        score2 = 0;
    }

    void Update()
    {
        teamWin();
    }

    public void DisplayScores()
    {
        Debug.Log("Team 1: " + score1 + " | Team 2: " + score2);
    }

    public void teamWin()
    {
        if (score1 >= 10)
        {
            Debug.Log("Team 1 wins!");
            score1 = 0;
            score2 = 0;
        }
        else if (score2 >= 10)
        {
            Debug.Log("Team 2 wins!");
            score1 = 0;
            score2 = 0;
        }   
    }
}
