using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    Rigidbody _rigidbody;

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update(){
        var moveInput = Input.GetAxis("Horizontal");
      
        //Set move Velocity
        var velocity = _rigidbody.velocity;
        velocity = new Vector3(moveInput * moveSpeed, velocity.y, 0);
        _rigidbody.velocity = velocity;
        
    }
}
