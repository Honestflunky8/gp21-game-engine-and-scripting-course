using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuickJump : MonoBehaviour
{
    [SerializeField] float jumpHeight = 5;
    [SerializeField] GroundChecker _groundChecker;
    Rigidbody _rigidbody;
    PlayerInputs _playerInputs;
    
    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
        _playerInputs = GetComponent<PlayerInputs>();
        if (GetComponent<GroundChecker>() != null){
            _groundChecker = GetComponent<GroundChecker>();
        }
    }

    void Update(){
        
        //Jump
        if (_playerInputs.JumpInput && _groundChecker.IsGrounded){
            _rigidbody.AddForce(Vector3.up * jumpHeight);
        }
    }
}
