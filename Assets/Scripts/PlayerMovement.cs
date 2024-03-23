using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D myRigidbody;

    void Run()
    {
        myRigidbody.velocity = moveInput;
    }

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Run();
    }

    void onMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
