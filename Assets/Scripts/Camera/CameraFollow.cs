using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Camera follow.
/// 
/// Following Video : @22.25  https://www.youtube.com/watch?v=qHdZ6JtKahk
/// </summary>
public class CameraFollow : MonoBehaviour {

	[SerializeField] private GameObject target;
	[SerializeField] private float minDistance;
	[SerializeField] private float speed;

	
	// Update is called once per frame
	void Update () {
		float _distance = Vector3.Distance (target.transform.position, transform.position);

		if(_distance < minDistance){
			
		}
	}
}
