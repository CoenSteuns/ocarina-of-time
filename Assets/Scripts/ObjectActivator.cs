using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivator : MonoBehaviour {

    public void ActivateObject()
    {
        this.gameObject.SetActive(true);
    }

    public void DeactivateGameobject()
    {
        this.gameObject.SetActive(false);
    }
}
