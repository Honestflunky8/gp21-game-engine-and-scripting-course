using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour{
    [SerializeField] float groundCheckLenght = 1f;
    [SerializeField] LayerMask groundLayers;
    [SerializeField] float groundCheckRadius;


    // void Awake(){
    //     groundCheckLenght = transform.lossyScale.y * 1.1f;
    // }

    public bool IsGrounded{
        get;
        private set;
    }
    void Update(){
        var ray = new Ray(transform.position, Vector3.down);
        IsGrounded = Physics.SphereCast(ray, groundCheckRadius,groundCheckLenght);
        Debug.DrawRay(transform.position,Vector3.down * groundCheckLenght, Color.magenta);
    }

    void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position + Vector3.down * groundCheckLenght, groundCheckRadius);
    }
}
