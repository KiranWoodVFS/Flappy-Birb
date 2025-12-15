using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float _flyBurstSpeed = 0.1f; // Amount of speed bird moves up

    Rigidbody _rb;
    private Vector3 _flyVector;

    // Gets rigidbody component
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Input for jump
        if (Input.GetButtonDown("Jump"))
        {
            _flyVector = transform.up * _flyBurstSpeed; // Creates new vector for bird

            // Applies the jump
            Jump();
        }
    }

    private void Jump()
    {
        _rb.linearVelocity = Vector3.zero; // Resets velocity
        _rb.AddForce(_flyVector * _flyBurstSpeed, ForceMode.Impulse); // Adds force
    }
}
