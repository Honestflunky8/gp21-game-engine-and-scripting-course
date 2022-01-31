using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5;
    [SerializeField] float chargingMoveSpeedFactor = 0.5f;
    Rigidbody _rigidbody;
    CommandContainer _commandContainer;
    GroundChecker _groundChecker;

    
    

    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
        _commandContainer = GetComponentInChildren<CommandContainer>();
        _groundChecker = GetComponent<GroundChecker>();
        
    }

    void Update(){

       var currentMoveSpeed = moveSpeed;

        if (_commandContainer.jumpCommand && _groundChecker.IsGrounded){
            currentMoveSpeed *= chargingMoveSpeedFactor;
        }
        //Set move Velocity
        var velocity = _rigidbody.velocity;
        velocity = new Vector3(_commandContainer.moveCommand * currentMoveSpeed, velocity.y, 0);
        _rigidbody.velocity = velocity;
        
    }
}
