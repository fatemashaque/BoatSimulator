using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBoatController : MonoBehaviour
{
    public float forwardForce = 10f;
    public float turnTorque = 2f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Keyboard.current == null) return;
        Keyboard keyboard = Keyboard.current;
        float moveInput = 0f;
        float turnInput = 0f;
        moveInput = keyboard.upArrowKey.isPressed ? 1f : keyboard.downArrowKey.isPressed? -1f :0f;
        turnInput = keyboard.leftArrowKey.isPressed ? -1f : keyboard.rightArrowKey.isPressed ? 1f : 0f;

        Vector3 move = transform.forward * moveInput * forwardForce;
        rb.AddForce(move, ForceMode.Force);

        Vector3 torque = Vector3.up * turnInput * turnTorque;
        rb.AddTorque(torque, ForceMode.Force);
    }
}
