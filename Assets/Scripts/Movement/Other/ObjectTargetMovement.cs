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

    private MovementHandler _movement;                  //the movement handler


    /// <summary>
    /// The target the object can move towards and away from.
    /// </summary>
    public GameObject target
    {
        get { return _target; }
        set { _target = value; }
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
    /// Makes the object move towards the target.
    /// </summary>
    public void moveTowardsTarget()
    {
        Vector3 direction = (_target.transform.position - this.transform.position);//the direction

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

    /// <summary>
    /// Makes the object move away from the target.
    /// </summary>
    public void moveAwayFromTarget()
    {
        Vector3 direction = -(_target.transform.position - this.transform.position);//the direction

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

    void Awake()
    {
        _movement = GetComponent<MovementHandler>();
    }    

}
