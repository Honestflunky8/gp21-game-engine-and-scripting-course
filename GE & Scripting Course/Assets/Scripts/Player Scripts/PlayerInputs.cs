using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour{
    [HideInInspector]
    public float MoveInput{
        get;
        private set;
    }

    [HideInInspector]
    public bool JumpInput{
        get;
        private set;
    }
  
    
    void Update()
    {
        MoveInput = Input.GetAxis("Horizontal"); 
        JumpInput = Input.GetKeyDown(KeyCode.Space);
    }
}
