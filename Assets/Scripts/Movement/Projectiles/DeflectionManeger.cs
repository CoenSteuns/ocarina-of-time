using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeflectionManeger : MonoBehaviour {

    public ConstantVelocity _targetMover;
    
    public void Bounce(GameObject target)
    {
        _targetMover.direction = target.transform.position - this.transform.position;
    }

}
