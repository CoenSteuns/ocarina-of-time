using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour {
	
    [SerializeField] private UnityEvent W;
    [SerializeField] private UnityEvent S;
    [SerializeField] private UnityEvent attack;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            W.Invoke();
        }
        if (Input.GetKey(KeyCode.S))
        {
            S.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack.Invoke();
        }
	}
}
