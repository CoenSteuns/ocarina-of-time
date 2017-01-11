using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HitCollider : MonoBehaviour {

	[SerializeField] private UnityEvent hit;
	[SerializeField] private string collider;
	private bool _isHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	bool OnTriggerEnter(Collider other){
		if (other.CompareTag(collider)) {

			print ("TRIGGER");

			hit.Invoke ();
			return _isHit = true;
		} else {
			return _isHit = false;
		}
	}
}
