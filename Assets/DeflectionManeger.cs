using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectionManeger : MonoBehaviour {

    public ObjectTargetMovement _targetMover;
    
    public void bounce(GameObject target)
    {
        _targetMover.target = target;
    }

}
