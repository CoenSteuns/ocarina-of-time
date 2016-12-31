using UnityEngine;
using System.Collections;

/// <summary>
/// The movement of an object based on a target.
/// </summary>
public class ObjectTargetMovement : MonoBehaviour {

    [SerializeField] private GameObject _target;        //the target
    [SerializeField] private float _minDistance;        //the minimum distance
    [SerializeField] private float _maxDistance;        //the maximum distance
    [SerializeField] private bool _groundOnly;          //if the object can follow on the y axis
    [SerializeField] private bool _isHoming;            //if the projectile follosw the target.

    private Vector3 _targetedPosition;                   //the position of the target
    private MovementHandler _movement;                  //the movement handler


    /// <summary>
    /// The target the object can move towards and away from.
    /// </summary>
    public GameObject target
    {
        get { return _target; }
        set
        {
            _target = value;
            SetNewTargetPosition();
        }
    }

    /// <summary>
    /// The maximum distance the object can have from the target.
    /// </summary>
    public float maxDistance
    {
        get { return _maxDistance; }
        set { _maxDistance = value; }
    }

    /// <summary>
    /// If this class can change the Y axis of this objects position
    /// </summary>
    public bool groundOnly
    {
        get { return _groundOnly; }
        set { _groundOnly = value; }
    }

    /// <summary>
    /// If the object is following the target.
    /// </summary>
    public bool isHoming
    {
        get { return _isHoming; }
        set { _isHoming = value; }
    }

    /// <summary>
    /// Makes the object move towards the target.
    /// </summary>
    public void moveTowardsTarget()
    {
        NewHomingPosition();//sets new position if it is homing
        Vector3 direction = (_targetedPosition - this.transform.position);//the direction
        if ((_targetedPosition - transform.position).magnitude > 0.1f)
        {
            if (direction.magnitude > _minDistance)//check min distance
            {
                if (_groundOnly)//if it can not move in the air
                {
                    direction.y = 0;//makes y 0.
                }
                direction.Normalize();
                _movement.SetNewDirection(direction);//sets the direction
            }
        }
    }

    /// <summary>
    /// Makes the object move away from the target.
    /// </summary>
    public void moveAwayFromTarget()
    {
        NewHomingPosition();//sets new position if it is homing
        Vector3 direction = -(_targetedPosition - this.transform.position);//the direction

        if ((_targetedPosition - transform.position).magnitude > 0.1f)
        {

            if (direction.magnitude < _maxDistance || _maxDistance == 0)//check max distance
            {
                if (_groundOnly)//if it can not move in the air
                {
                    direction.y = 0;//makes y 0.
                }
                direction.Normalize();
                _movement.SetNewDirection(direction);//sets the direction
            }

        }
    }

    void Awake()
    {
        _movement = GetComponent<MovementHandler>();
        SetNewTargetPosition();
    }

    /// <summary>
    /// check if it is homing before it sets a new position.
    /// </summary>
    private void NewHomingPosition()
    {
        if (_isHoming)
        {
             SetNewTargetPosition();
        }
    }

    /// <summary>
    /// sets the targeted position to the targets new position.
    /// </summary>
    private void SetNewTargetPosition()
    {
            _targetedPosition = _target.transform.position;
    }

}
