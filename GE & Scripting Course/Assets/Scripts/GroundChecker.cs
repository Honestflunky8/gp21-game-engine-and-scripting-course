using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour{
    [SerializeField] float groundCheckLenght = 1f;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayers;

    public bool IsGrounded{
        get;
        private set;
    }
    void Update(){
        GroundCheck();
    }

    /// <summary>
    /// Casts a sphere from the transform's position downwards, dependant on radius, max distance and a layermask
    /// </summary>
    void GroundCheck(){
        var ray = new Ray(transform.position, Vector3.down);
        IsGrounded = Physics.SphereCast(ray, groundCheckRadius,groundCheckLenght,groundLayers);
        //Debug.DrawRay(transform.position,Vector3.down * groundCheckLenght, Color.magenta);
    }

    void OnDrawGizmos(){
        Gizmos.DrawWireSphere(transform.position + Vector3.down * groundCheckLenght, groundCheckRadius);
    }
}
