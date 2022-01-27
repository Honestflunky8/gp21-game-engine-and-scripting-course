using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    Rigidbody _rigidbody;
    PlayerInputs _playerInputs;

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
        _playerInputs = GetComponent<PlayerInputs>();
        
    }

    void Update(){

        //Set move Velocity
        var velocity = _rigidbody.velocity;
        velocity = new Vector3(_playerInputs.MoveInput * moveSpeed, velocity.y, 0);
        _rigidbody.velocity = velocity;
        
    }
}
