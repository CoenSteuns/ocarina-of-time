using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deflect : MonoBehaviour {

    [SerializeField] private float _range;

    /// <summary>
    /// deflects all deflectable objects
    /// </summary>
	public void DeflectProjectiles()
    {
        Collider[] allColliders = Physics.OverlapSphere(this.transform.position, _range);
        GameObject target = GetComponent<TargetHolder>().target;
        for(int i = 0; i < allColliders.Length; i++)
        {
            if (allColliders[i].CompareTag("Projectile"))
            {
                Collider projectile = allColliders[i];
                projectile.gameObject.GetComponent<DeflectionManeger>().bounce(target);
            }
        }
    }
}
