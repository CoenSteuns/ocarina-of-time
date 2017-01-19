using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardTurner : MonoBehaviour
{
    public Transform target { get; set; }

	// Use this for initialization
	void Start ()
	{
        //transform.LookAt(transform.position + (target.position - transform.position));
        //transform.LookAt(transform.position + target.position);
        //target.position
    }

    // Update is called once per frame
    void Update () {
     transform.LookAt(transform.position + (transform.position - GetComponent<ConstantVelocity>().direction));   
    }
}
