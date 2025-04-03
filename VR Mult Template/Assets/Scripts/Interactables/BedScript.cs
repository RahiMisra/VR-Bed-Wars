using UnityEngine;

public class BedScript : Destructable
{
    public int team;
    public GameplayScript gameplayScript;
    void Start()
    {
        gameplayScript = FindFirstObjectByType<GameplayScript>();
    }
    void Update()
    {
        
    }
    
    public override void Die()
    {
        Debug.Log("Bed destroyed");
        if (team == 1)
        {
            gameplayScript.score2 += 1;
        }
        else if (team == 2)
        {
            gameplayScript.score1 += 1;
        }
        base.Die();
    }

}
