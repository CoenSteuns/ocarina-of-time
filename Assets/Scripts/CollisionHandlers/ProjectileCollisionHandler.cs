using UnityEngine;
using System.Collections;

public class ProjectileCollisionHandler : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy") || other.CompareTag("Player"))
        {
            if(other.GetComponent<ConstantVelocity>() != null)
            other.GetComponent<ConstantVelocity>().StartMoving();


            Destroy(this.gameObject);
        }
    }
}
