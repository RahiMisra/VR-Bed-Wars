using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Destructable : MonoBehaviour
{
    public float durability;
    public bool isDestroyed = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("Taking damage");
        if (isDestroyed) return;
        durability -= damage;
        if (durability <= 0) Die();
    }

    public virtual void Die()
    {
        isDestroyed = true;
        Destroy(gameObject);
    }
}
