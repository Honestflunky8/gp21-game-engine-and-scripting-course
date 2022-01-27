using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SpeedMultiplier SO", menuName = "Affectors/Speed Multiplier")]
public class SpeedMultiplierSO : ScriptableObject{
    [Min(0)][SerializeField] float speedMultiplier;
    
}
