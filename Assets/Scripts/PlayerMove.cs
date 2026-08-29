using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 direction;

    public Rigidbody rb;

    void Update()
    {
        direction = Vector3.zero;

            if (Keyboard.current[Key.W].isPressed)
        {
            direction += transform.forward;
        }
        if (Keyboard.current[Key.S].isPressed)
        {
            direction -= transform.forward;
        }

        if (Keyboard.current[Key.A].isPressed)
        {
            direction -= transform.right;
        }

        if (Keyboard.current[Key.D].isPressed)
        {
            direction += transform.right;
        }

        direction = Vector3.ClampMagnitude(direction, 1f);
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(direction.x * speed,
        rb.linearVelocity.y, direction.z * speed);
    }
}
