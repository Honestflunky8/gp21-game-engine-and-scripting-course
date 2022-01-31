using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour{


    CommandContainer _commandContainer;

    void Awake(){
        _commandContainer = GetComponentInChildren<CommandContainer>();
    }

    [HideInInspector]
    public float MoveInput{
        get;
        private set;
    }

    [HideInInspector]
    public bool JumpInputDown{
        get;
        private set;
    }
    [HideInInspector]
    public bool JumpInputUp{
        get;
        private set;
    }
    
    [HideInInspector]
    public bool JumpInput{
        get;
        private set;
    }
  
    
    void Update(){
        SetCommands();
    }

    void SetCommands(){
        _commandContainer.moveCommand = Input.GetAxis("Horizontal");
        _commandContainer.jumpCommandDown = Input.GetKeyDown(KeyCode.Space);
        _commandContainer.jumpCommandUp = Input.GetKeyUp(KeyCode.Space);
        _commandContainer.jumpCommand = Input.GetKey(KeyCode.Space);
    }
}
