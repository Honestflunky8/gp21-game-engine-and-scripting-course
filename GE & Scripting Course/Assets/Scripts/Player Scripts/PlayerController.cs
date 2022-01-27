using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
   [SerializeField] float moveSpeed = 5;
   [SerializeField] float maxMoveSpeed = 10;
   [SerializeField] float jumpHeight = 5;
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
      
      //Get jump input
      var jumpInput = Input.GetKeyDown(KeyCode.Space);
      //Jump
      if (jumpInput && _rigidbody.velocity.y < 0.5 && _rigidbody.velocity.y !< 0){
         _rigidbody.AddForce(Vector3.up * jumpHeight);
      }
   }
}
