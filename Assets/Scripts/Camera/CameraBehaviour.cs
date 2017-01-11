using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Camera behaviour.
/// This Script is responsible for the Special Camera Behaviour
/// Looks Down on player & target if target on Ground
/// Looks Up on player & target if target is in Air
/// </summary>
public class CameraBehaviour : MonoBehaviour {

	[SerializeField] private Transform target;
	[SerializeField] private float minimalY;
	[SerializeField] private float maximalY;
	[SerializeField] private float speed;

	// Update is called once per frame
	void Update () {
		if(target.position.y > minimalY){
			transform.position = Vector3.MoveTowards (transform.position, new Vector3(transform.position.x,minimalY,transform.position.z), speed*Time.deltaTime);
		}
		if(target.position.y < minimalY){
			transform.position = Vector3.MoveTowards (transform.position, new Vector3(transform.position.x,maximalY,transform.position.z), speed*Time.deltaTime);
		}
	}
}
