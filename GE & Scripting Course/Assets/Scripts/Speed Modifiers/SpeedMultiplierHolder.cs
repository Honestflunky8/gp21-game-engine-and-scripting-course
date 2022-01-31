using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedMultiplierHolder : MonoBehaviour{
  [SerializeField] SpeedMultiplierSO _speedMultiplierSo;
  [SerializeField] float effectDuration;
  [SerializeField] bool temporaryBoostAfterExit;

  void OnCollisionEnter(Collision collision){
    if (collision.collider.CompareTag("Player")){
      var _playerWalking = collision.collider.GetComponent<PlayerWalking>();
      _playerWalking.moveSpeed *= _speedMultiplierSo.speedMultiplier;
    }
    
  }

  void OnCollisionExit(Collision other){
    
     if (other.collider.CompareTag("Player")){ 
       var _playerWalking = other.collider.GetComponent<PlayerWalking>(); 
       if (temporaryBoostAfterExit){
         StartCoroutine(TemporaryEffectPlayer(_playerWalking));
       }
       else _playerWalking.moveSpeed /= _speedMultiplierSo.speedMultiplier;
    }
  }


  IEnumerator TemporaryEffectPlayer(PlayerWalking playerWalking){
    yield return new WaitForSeconds(effectDuration);
    playerWalking.moveSpeed /= _speedMultiplierSo.speedMultiplier;
  }
}



