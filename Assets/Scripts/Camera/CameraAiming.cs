using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Camera aiming.
/// This Class is responsible for the Aiming of the Camera when on TARGET LOCK
/// https://www.reddit.com/r/gamedev/comments/2scqxa/ocarina_of_times_ztargeting_mechanic/?st=ixua9kld&sh=710dc2a5     http://imgur.com/a/ivuhk
/// or
/// https://www.reddit.com/r/gamedev/comments/14lxsj/3d_camera_demonstration_implementation_and/
/// </summary>
public class CameraAiming : MonoBehaviour {
	/* WhatDoesItNeedToDO
	 * Check Distance From TARGET & PLAYER
	 * CenterPoint = Distance / 2
	 * CenterPoint + Offset from PLAYER
	 * Get Angle from (CenterPoint & PLAYER)
	 */

	[SerializeField] private Transform target;
	[SerializeField] private Transform player;

	[SerializeField] private Vector3 cameraOffset;

	private Vector3 lookAtPoint;

	private bool isLocked;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("TargetLock").transform;
		player = GameObject.Find ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(isLocked && target != null){
			float distance = Vector3.Distance (target.position, player.position);
			float centerPoint = distance / 2;

			lookAtPoint = new Vector3(centerPoint, centerPoint, centerPoint);

		} else if (!isLocked){
			lookAtPoint = player.position;
		}

		transform.LookAt (lookAtPoint);
	}

}
