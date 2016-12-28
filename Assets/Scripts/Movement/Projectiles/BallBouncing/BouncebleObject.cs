using UnityEngine;
using System.Collections;

public class BouncebleObject : MonoBehaviour {

    [SerializeField] private BouncableObjectHolder _objects;
    [SerializeField] private bool _startBounceble;
    
	void Start () {
       if (_startBounceble)
        {
            AddBounce();
        }

	}

    public void DeleteBounce()
    {
        _objects.bouncableObjects.Remove(this.gameObject);
    }

    public void AddBounce()
    {
        _objects.bouncableObjects.Add(this.gameObject);
    }
}
