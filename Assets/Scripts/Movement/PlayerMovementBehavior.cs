using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    public CharacterController Controller;

    // The numbers for the player's speed, the gravity that affects them, and how high they can jump.
    public float Speed = 12f;
    public float Gravity = -9.81f;

    private Vector3 _velocity;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * Speed * Time.deltaTime);

        _velocity.y += Gravity * Time.deltaTime;

        Controller.Move(_velocity * Time.deltaTime);
    }
}
