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
        var allColliders = Physics.OverlapSphere(this.transform.position, _range);
        var target = GetComponent<TargetHolder>().target;
        foreach (var t in allColliders)
        {
            if (!t.CompareTag("Projectile")) continue;
            var projectile = t;
            projectile.gameObject.GetComponent<DeflectionManeger>().Bounce(target);
        }
    }
}
