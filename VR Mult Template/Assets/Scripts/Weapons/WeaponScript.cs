using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    public float damage;
    public int team;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        var other = collision.gameObject;
        if (other.CompareTag("Player"))
        {
            var target = other.GetComponent<Player>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
        else if (other.CompareTag("Destructable"))
        {
            var target = other.GetComponent<Destructable>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

}
