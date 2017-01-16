using UnityEngine;
using System.Collections;

/// <summary>
/// Handels the movement of an object.
/// </summary>
public class MovementHandler : MonoBehaviour {

	[SerializeField] private float _speed = 1;              //the speed
    [SerializeField] private float _maxSpeed = 20;          //the maximum speed
    [SerializeField] private float _minSpeed = 0;           //the minimum speed
    [SerializeField] private bool _canMove = true;         //if the object can move

    private Vector3 _direction;         //The direction the object is moving towards
    
    /// <summary>
    /// The speed at which the object will move.
    /// </summary>
    public float speed
    {
        get { return _speed; }
        set { _speed = CheckSpeed(value); }
    }

    /// <summary>
    /// If the object is able to move.
    /// </summary>
    public bool canMove
    {
        get { return _canMove; }
        set { _canMove = value; }
    }

    /// <summary>
    /// The maximum speed at which the object can move.
    /// </summary>
    public float maxSpeed
    {
        get { return _maxSpeed; }
    }

    /// <summary>
    /// The minimum speed at which the object can move.
    /// </summary>
    public float minSpeed
    {
        get { return _minSpeed; }
    }

    /// <summary>
    /// Resets all the other directions given and set the new direction
    /// </summary>
    /// <param name="direction">The new movementDirection</param>
    public void SetNewDirection(Vector3 direction)
    {
        ResetDirection();
        AddDirection(direction);
    }

    /// <summary>
    /// Adds a direction to the movement direction.
    /// </summary>
    /// <param name="direction">The direction you want to add.</param>
    public void AddDirection(Vector3 direction)
    {
        direction.Normalize();
        _direction += direction;
    }

    /// <summary>
    /// Make the direction 0.
    /// </summary>
    public void ResetDirection()
    {
        _direction = Vector3.zero;
    }

    //Update is called upon once ecery frame.
    void Update()
    {
        if (_canMove)//if the object can move
        {
            transform.position += _direction * speed * Time.deltaTime;//the object wil move
        }
        ResetDirection();//reset,  if it doesn't get a new direction it wil stop moving.
    }

    /// <summary>
    /// Checks if the speed is within the set range.
    /// </summary>
    /// <param name="speed">Speed that will be checked</param>
    /// <returns>Speed within the set range</returns>
    private float CheckSpeed(float speed)
    {
        if(speed > _maxSpeed)
        {
            speed = _maxSpeed;
        }
        else if(speed < _minSpeed)
        {
            speed = _minSpeed;
        }
        return speed;
    }


}
