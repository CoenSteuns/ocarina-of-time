using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownScalaer : MonoBehaviour
{

    [SerializeField] private float _startScale;
    [SerializeField] private float _growth;
    [SerializeField] private float _speed;

    [SerializeField] private bool _x;
    [SerializeField] private bool _y;
    [SerializeField] private bool _z;
	
	// Update is called once per frame
	void Update ()
	{
        Vector3 scale = new Vector3();
        if (_z){scale.z = _startScale + Mathf.Sin(Time.time*_speed)*_growth;}
        if (_y) { scale.y = _startScale + Mathf.Sin(Time.time*_speed)*_growth; }
        if (_x) { scale.x = _startScale + Mathf.Sin(Time.time*_speed)*_growth; }

	    transform.localScale = scale;

	}
}
