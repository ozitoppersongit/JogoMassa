using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float speed = 10f;

    public Rigidbody rb;

    private void FixedUpdate()
    {
        Vector3 direction = Vector3.zero;

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

        if (Keyboard.current[Key.Space].isPressed)
        {
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        direction = Vector3.ClampMagnitude(direction, 1f);

        rb.linearVelocity = new Vector3(direction.x * speed, rb.linearVelocity.y, direction.z * speed);
    }
}
