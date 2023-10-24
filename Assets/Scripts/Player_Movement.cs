using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Player_Movement : MonoBehaviour
{
    private Vector2 moveVector;
    [SerializeField] float moveSpeed = 10f;

    private void Update()
    {
        movePlayer();
    }
    
    public void onMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }
    public void movePlayer()
    {
        Vector3 movement = new Vector3(moveVector.x, 0f, moveVector.y);
        
        // This is for natural rotation of a 3D object, it will rotate in the direction of where it is moving
        // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
    
}
