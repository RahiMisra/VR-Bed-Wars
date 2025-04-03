using UnityEngine;
using UnityEngine.InputSystem;

public class InteractCubeScript : MonoBehaviour
{
    public InputActionReference trigger;
    public Material oldMat;
    public Material newMat;



    void Start()
    {
        
    }

    void Update()
    {
        if (trigger.action.IsPressed())
        {
            GetComponent<Renderer>().material = newMat;
        }
        else
        {
            GetComponent<Renderer>().material = oldMat;
        }
    }
}
