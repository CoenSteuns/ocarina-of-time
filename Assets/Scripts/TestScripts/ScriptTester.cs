using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ScriptTester : MonoBehaviour {

    public UnityEvent testEvent;
    public UnityEvent testEvent2;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            testEvent.Invoke();
        }

        if (Input.GetKey(KeyCode.T))
        {
            testEvent2.Invoke();
        }
    }
}
