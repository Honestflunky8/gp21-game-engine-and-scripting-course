using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuickJump : MonoBehaviour
{
    [SerializeField] float jumpHeight = 5;
    Rigidbody _rigidbody;
    
    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update(){
        //Get jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        //Jump
        if (jumpInput && _rigidbody.velocity.y < 0.5 && _rigidbody.velocity.y !< 0){
            _rigidbody.AddForce(Vector3.up * jumpHeight);
        }
    }
}
