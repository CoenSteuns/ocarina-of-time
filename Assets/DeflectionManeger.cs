using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectionManeger : MonoBehaviour {

    public GameObject target;
    public ObjectTargetMovement _targetMover;
    
    public void bounce()
    {
        _targetMover.target = target;
    }

}
