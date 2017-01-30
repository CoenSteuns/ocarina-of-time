using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	[SerializeField] private bool x;
    [SerializeField] private bool y;
    [SerializeField] private bool z;

    [SerializeField] private float speed;

    void Update()
    {
        Vector3 scale = new Vector3();
        if (z) { scale.z = speed;}
        if (y) { scale.y = speed; }
        if (x) { scale.x = speed; }
        transform.Rotate(scale);
    }
}
