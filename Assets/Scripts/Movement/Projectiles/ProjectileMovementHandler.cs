using UnityEngine;
using System.Collections;

public class ProjectileMovementHandler : MonoBehaviour {

    private ConstantVelocity _targetMover;

	void Awake () {
        _targetMover = GetComponent<ConstantVelocity>();
	}
	
	void Update () {
        
	}   
}
