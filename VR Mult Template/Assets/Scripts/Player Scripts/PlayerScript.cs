using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100;
    public float maxHealth = 100;
    public float shield = 50;
    public float maxShield = 50;
    public float stamina = 100;
    public int team;
    public bool isDead = false;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        if (isDead) return;
        if (shield > 0)
        {
            shield -= damage;
            if (shield < 0)
            {
                health += shield; // subtract the negative shield value from health
                shield = 0;
            }
        }
        else
        {
            health -= damage;
        }
        if (health <= 0) Die();
    }

    void Die()
    {
        isDead = true;
    }
}
