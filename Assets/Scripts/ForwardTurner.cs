using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardTurner : MonoBehaviour
{

    private Vector3 _target;
    private Vector3 _oldTarget;
    private float _offset;

    [SerializeField] private bool _isUpdating;
    [SerializeField] private bool _isLookingAway;
    [SerializeField] private bool _updateOnTargetChange;

    /// <summary>
    /// If it should look at the new target as soon as it changes.
    /// </summary>
    public bool updateOnTargetChange
    {
        get {return _updateOnTargetChange;}
        set { _updateOnTargetChange = value; }
    }

    /// <summary>
    /// If it only refreshes every frame.
    /// </summary>
    public bool isUpdating {
        private get { return _isUpdating; }
        set
        {
            _isUpdating = value;
            if (value)
            {
                StartCoroutine(UpdateLookingDirection());
            }
        }
    }

    /// <summary>
    /// If the target is looking away from or towards the target.
    /// </summary>
    public bool isLookingAway
    {
        get { return _isLookingAway; }
        set { _isLookingAway = value; }
    }

    /// <summary>
    /// The target it will look at.
    /// </summary>
    public Vector3 target
    {
        get { return _target; }
        private set
        {
            _target = value;
        }
    }

    /// <summary>
    /// Sets a new position.
    /// </summary>
    /// <param name="targetObject">The object </param>
    public void SetNewTarget(GameObject targetObject)
    {
        SetNewTarget(targetObject.transform.position);
    }
    public void SetNewTarget(Transform targetTransform)
    {
        SetNewTarget(targetTransform.position);
    }
    public void SetNewTarget(Vector3 pos)
    {
        target = pos;
        if (!_updateOnTargetChange) return;
        SetNewDirection();
    }

    /// <summary>
    /// Makes this object look towards the target.
    /// </summary>
    public void SetNewDirection()
    {
        var lookAt = _isLookingAway ? target : transform.position + (transform.position - target);
        print(lookAt);
        transform.LookAt(lookAt);
        //TurnCalculator(lookAt, 5);
    }

    private IEnumerator UpdateLookingDirection()
    {
        while (_isUpdating)
        {
            SetNewDirection();
            yield return null;
        }
    }

    private IEnumerator TurnCalculator(Vector3 target, float time)
    {
        Vector3 lookingAt = transform.forward.normalized * target.magnitude;
        Vector3 lookat = lookingAt;
        float starttime = time;
        while ((target - lookat).magnitude > _offset)
        {
            time -= Time.deltaTime;
            lookat = (target - lookingAt) / starttime * (starttime - time);
            transform.LookAt(lookat);
            yield return null;
        }


    }
}
