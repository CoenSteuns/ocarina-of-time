using UnityEngine;
using System.Collections;

public class ProjectileMovementHandler : MonoBehaviour {

    private ObjectTargetMovement _targetMover;

	void Awake () {
        _targetMover = GetComponent<ObjectTargetMovement>();
	}
	
	void Update () {
        _targetMover.moveTowardsTarget();
	}   
}
