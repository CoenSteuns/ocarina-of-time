using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Health.
/// This script is responsible for the Health of Characters
/// </summary>
public class Health : MonoBehaviour {

	[SerializeField] private float maxHealth;
	private float _currentHealth;

	public void SubtractHealth(float subtract){
		_currentHealth -= subtract;
	}

	// Use this for initialization
	void Start () {
		_currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {

		print (this+" CurrentHealth: "+_currentHealth);

		if(_currentHealth > maxHealth){
			print ("CHEATER!");
			_currentHealth = maxHealth;
		}

		if(_currentHealth == 0){
			print (this +" IS DEAD");
		}	
	}
}
