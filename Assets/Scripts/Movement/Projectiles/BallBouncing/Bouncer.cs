using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Bouncer : MonoBehaviour
{
    [SerializeField] private float _bounceRange;
    [SerializeField] private BouncableObjectHolder _objects;

    public void Bounce()
    {
        for(int i = 0; i < _objects.bouncableObjects.Count; i++)
        {
            float distanceToProjectile = (_objects.bouncableObjects[i].transform.position - transform.position).magnitude;
            if (distanceToProjectile < _bounceRange)
            {
                if(_objects.bouncableObjects[i].GetComponent<ObjectTargetMovement>().target == this.gameObject)
                {
                    _objects.bouncableObjects[i].GetComponent<ObjectBouncer>().Bounce();
                }
            }
        }
    }
}
