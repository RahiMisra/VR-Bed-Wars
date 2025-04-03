using UnityEngine;

public class FireArrow : MonoBehaviour
{
    public GameObject arrow;
    public Transform firePoint;
    public float arrowSpeed = 20f;


    public void Fire()
    {
        Quaternion rotation = firePoint.rotation * Quaternion.Euler(90, 0, 0);
        GameObject newArrow = Instantiate(arrow, firePoint.position, rotation);
        Rigidbody rb = newArrow.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(firePoint.forward * arrowSpeed, ForceMode.Impulse);
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
