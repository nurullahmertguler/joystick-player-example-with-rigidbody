using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FloatingJoystick variableJoystick;
    public Rigidbody rb;
    public Vector3 direction;

    public bool JoystcikControlBool=true;

    public bool Walking=false;

    public static JoystickPlayerExample Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        
    }
    public void FixedUpdate()
    {
        direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        if (Input.GetMouseButton(0) && direction != Vector3.zero && JoystcikControlBool)
        {
            Walking = true;
            rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
            if(direction != Vector3.zero) transform.forward = direction / 5;
        }
        else
        {
            Walking = false;
        }
        
    }
}