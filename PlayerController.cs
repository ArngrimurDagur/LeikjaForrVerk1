using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    // 
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Update()
    {
        // Sækja inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Fer áfram með þessu
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Snýst með þessu
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
