using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstantiotor : MonoBehaviour
{

    public GameObject g;

	// Use this for initialization
	void Start ()
	{
	    Instantiate(g);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
