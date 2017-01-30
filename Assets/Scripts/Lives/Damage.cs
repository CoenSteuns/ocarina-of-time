using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    [SerializeField] private int _damage = 1;//the damage

    /// <summary>
    /// The amount of damage that has to be done.
    /// </summary>
    public int damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

	public void DamageObject(GameObject otherObject)
    {
        otherObject.GetComponent<Health>().SubtractHealth(_damage);//damage the object
    }
}
