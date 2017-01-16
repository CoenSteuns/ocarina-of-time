using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Camera follow.
/// 
/// Following Video : @22.25  https://www.youtube.com/watch?v=qHdZ6JtKahk
/// </summary>
public class CameraFollow : MonoBehaviour {

	[SerializeField] private Transform target;
	[SerializeField] private float distance;
	[SerializeField] private float offsetY;
	[SerializeField] private float speed;

	private bool resetCam;
	
	// Update is called once per frame
	void Update () {
		float _distance = Vector3.Distance (target.position, transform.position);
		Vector3 _behind = target.position - new Vector3 (target.transform.forward.x * distance, target.transform.forward.z * distance); 

		//RESET CAMERA POSITION
		if (!resetCam && Input.GetKey("z")) {
			resetCam = true;
		} else if (resetCam) {
			transform.LookAt (target.transform);
			transform.position = Vector3.MoveTowards (transform.position, _behind, 30 * Time.deltaTime);
			if (transform.position == _behind) {
				resetCam = false; 
			}
		} else {

		//FOLLOW THE PLAYER
			if (_distance < distance) {
				//NEED TO BE DONE BIJ CAMERA AIM
				transform.LookAt (target.transform);
			} else if (_distance > distance * 2) {
				//NEED TO BE DONE BIJ CAMERA AIM
				transform.LookAt (target.transform);
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (target.position.x, target.position.y + offsetY, target.position.z - distance), speed * 3 * Time.deltaTime);
			} else if (_distance < distance * 2 && _distance > distance) {
				//NEED TO BE DONE BIJ CAMERA AIM
				transform.LookAt (target.transform);
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (target.position.x, target.position.y + offsetY, target.position.z - distance), speed * Time.deltaTime);
			}
		}
	}
}
