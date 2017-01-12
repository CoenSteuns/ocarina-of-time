using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCorrection : MonoBehaviour {
	[SerializeField] private GameObject _target;
	private Renderer _targetRenderer;
	private float _defaultFoV = 60f;


	void Start(){
		_targetRenderer = _target.GetComponent<Renderer> ();
	}


	void Update(){
		if (!_targetRenderer.isVisible) {

			Camera.main.fieldOfView++;
	//	} else if (_targetRenderer.isVisible && Camera.main.fieldOfView > 60) {
	//		Camera.main.fieldOfView--;

	//	} else if(Camera.main.fieldOfView < 60){
		//	Camera.main.fieldOfView = 60;
		}
	}
}
