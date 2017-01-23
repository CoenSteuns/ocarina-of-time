using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

[System.Serializable]
public class onDeflect : UnityEvent<Vector3> { }

public class DeflectionManeger : MonoBehaviour
{

    [SerializeField] private onDeflect _onDeflect;

    public ConstantVelocity _targetMover;
    
    public void Bounce(GameObject target)
    {
        _onDeflect.Invoke(target.transform.position - this.transform.position);
        //_targetMover.SetDirection(target.transform.position - this.transform.position);
        //GetComponent<ForwardTurner>().SetNewTarget(target.transform.position - this.transform.position);
    }

}
