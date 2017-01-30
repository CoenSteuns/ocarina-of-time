using UnityEngine;
using System.Collections;

/// <summary>
/// A constant movement.
/// </summary>
public class ConstantVelocity : MonoBehaviour {

    
    [SerializeField] private Vector3 _direction;//The direction the the object wil keep moving in.
    [SerializeField] private bool _isMoving = false;//If the object is moving.

    private MovementHandler _movement;//the movement handler

    public Vector3 Direction
    {
        get { return _direction; }
    }
    
    /// <summary>
    /// If the object is moving.
    /// </summary>
    public bool isMoving
    {
        get { return _isMoving; }
    }

    /// <summary>
    /// Starts to make the object move in the set direction
    /// </summary>
    public void StartMoving()
    {
        _isMoving = true;
    }

    /// <summary>
    /// stops the object from moving in the set direction.
    /// </summary>
    public void StopMoving()
    {
        _isMoving = false;
    }


    /// <summary>
    /// Set the direction.
    /// </summary>
    /// <param name="position">the position it </param>
    public void SetDirection(GameObject position)
    {
        SetDirection(transform.position - position.transform.position);
    }
    public void SetDirection(Transform position)
    {
        SetDirection(position.position);
    }
    public void SetDirection(Vector3 position)
    {
        _direction = position;
    }

    void Awake()
    {
        _movement = GetComponent<MovementHandler>();
    }

    void Update()
    {
        if (_isMoving)
        {
            _movement.SetNewDirection(_direction);//sets the direction as the new movement direction.
        }
    }
}
