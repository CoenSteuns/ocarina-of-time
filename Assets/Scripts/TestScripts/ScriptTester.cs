using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ScriptTester : MonoBehaviour {

    public KeyCode key = KeyCode.T;

    public UnityEvent KeyDown;
    public UnityEvent GetKey;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(key))
        {
            KeyDown.Invoke();
        }

        if (Input.GetKey(key))
        {
            GetKey.Invoke();
        }
    }
}
