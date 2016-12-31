using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deflect : MonoBehaviour {

    [SerializeField] private float _range;

	public void DeflectProjectiles()
    {
        Collider[] allColliders = Physics.OverlapSphere(this.transform.position, _range);
        for(int i = 0; i < allColliders.Length; i++)
        {
            if (allColliders[i].CompareTag("Projectile"))
            {
                Collider projectile = allColliders[i];
                projectile.gameObject.GetComponent<DeflectionManeger>().bounce();
            }
        }
    }
}
