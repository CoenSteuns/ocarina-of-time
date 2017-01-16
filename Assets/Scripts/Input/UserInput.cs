using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UserInput : MonoBehaviour {

    public KeyCode[] oneTimeKeys;
    public UnityEvent[] oneTimeEvents;

    public KeyCode[] updateKeys;
    public UnityEvent[] updateEvents;

    void Update()
    {
        if (!Input.anyKey) return;
        for (var i = 0; i < updateKeys.Length; i++)
        {
            if (Input.GetKey(updateKeys[i]))
            {
                updateEvents[i].Invoke();
            }
        }
        if (!Input.anyKeyDown) return;
        for (var i = 0; i < oneTimeKeys.Length; i++)
        {
            if (Input.GetKey(oneTimeKeys[i]))
            {
                oneTimeEvents[i].Invoke();
            }
        }
    }
}
