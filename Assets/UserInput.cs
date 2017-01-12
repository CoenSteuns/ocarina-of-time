using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UserInput : MonoBehaviour {

    public KeyCode[] OneTimeKeys;
    public UnityEvent[] oneTimeEvents;

    public KeyCode[] UpdateKeys;
    public UnityEvent[] UpdateEvents;

    void Update()
    {
        if (Input.anyKey)
        {
            for(int i = 0; i < UpdateKeys.Length; i++)
            {
                if (Input.GetKey(UpdateKeys[i]))
                {
                    UpdateEvents[i].Invoke();
                }
            }
            if (Input.anyKeyDown)
            {
                for (int i = 0; i < OneTimeKeys.Length; i++)
                {
                    if (Input.GetKey(OneTimeKeys[i]))
                    {
                        oneTimeEvents[i].Invoke();
                    }
                }
            }
        }
    }

}
