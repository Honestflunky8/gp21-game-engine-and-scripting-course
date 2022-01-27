using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJump : MonoBehaviour
{
    [SerializeField] float minJumpHeight = 100;
    [SerializeField] float maxJumpHeight = 1000;
    [SerializeField] float chargeTime = 1f;
    [SerializeField] GroundChecker _groundChecker;
    
    float jumpCharge;
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
        if (_playerInputs.JumpInput){
            jumpCharge += Time.deltaTime / chargeTime;
        }

        if (_playerInputs.JumpInputUp){
            if (_groundChecker.IsGrounded){
                var jumpForce = Mathf.Lerp(minJumpHeight, maxJumpHeight, jumpCharge);
                _rigidbody.AddForce(Vector3.up * jumpForce);
            }
            jumpCharge = 0f;
        }
    }
}
