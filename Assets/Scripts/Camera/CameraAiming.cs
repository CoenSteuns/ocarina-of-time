using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAiming : MonoBehaviour {
	/*
	//https://www.reddit.com/r/gamedev/comments/2scqxa/ocarina_of_times_ztargeting_mechanic/?st=ixua9kld&sh=710dc2a5
	//http://imgur.com/a/ivuhk
	//Check Distance From TARGET & PLAYER
	//CenterPoint = Distance / 2 
	//CenterPoint + Offset from PLAYER
	//Get Angle from (CenterPoint & PLAYER)

	//https://www.reddit.com/r/gamedev/comments/14lxsj/3d_camera_demonstration_implementation_and/

	[SerializeField] private Transform target;
	[SerializeField] private Transform player;
	[SerializeField] private Vector3 offset;

	private float distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector2.Distance (target,player);
		float centerpoint = distance / 2;

		transform.LookAt (centerpoint);

		float angle = Mathf.Atan2 (centerpoint, player);
	}
	*/
}
