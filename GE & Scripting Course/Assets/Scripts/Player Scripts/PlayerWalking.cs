using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    [SerializeField] float chargingMoveSpeedFactor = 0.5f;
    Rigidbody _rigidbody;
    PlayerInputs _playerInputs;
    GroundChecker _groundChecker;

    
    

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
        _playerInputs = GetComponent<PlayerInputs>();
        _groundChecker = GetComponent<GroundChecker>();
        
    }

    void Update(){

       var currentMoveSpeed = moveSpeed;

        if (_playerInputs.JumpInput && _groundChecker.IsGrounded){
            currentMoveSpeed *= chargingMoveSpeedFactor;
        }
        //Set move Velocity
        var velocity = _rigidbody.velocity;
        velocity = new Vector3(_playerInputs.MoveInput * currentMoveSpeed, velocity.y, 0);
        _rigidbody.velocity = velocity;
        
    }
}
