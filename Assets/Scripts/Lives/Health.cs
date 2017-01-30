using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Health.
/// This script is responsible for the Health of Characters
/// </summary>
public class Health : MonoBehaviour {

	[SerializeField] private float _maxHealth = 10;
    [SerializeField] private float _minHealth = 1;
	private float _currentHealth;

    public float currentHealth
    {
        get { return _currentHealth; }
        set { _maxHealth = value; }
    }
    public float maxHealth
    {
        get { return _currentHealth; }
    }
    public float minHealth
    {
        get { return _currentHealth; }
    }

    public void SubtractHealth(float subtract){
		_currentHealth -= subtract;
	    CheckHealth();

	}
    public void AddHealth(float add)
    {
        _currentHealth += add;
        CheckHealth();
    }

    void Start () {
		_currentHealth = _maxHealth;
	}
	
	/// <summary>
    /// Checks if the health is more then the maximum amount of health.
    /// </summary>
	void CheckHealth () {
		if(_currentHealth > _maxHealth){
			_currentHealth = _maxHealth;
		}
	}
}
