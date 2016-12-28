using UnityEngine;
using System.Collections;

/// <summary>
/// A constant movement.
/// </summary>
public class ConstantVelocity : MonoBehaviour {

    
    [SerializeField] private Vector3 _direction;//The direction the the object wil keep moving in.
    [SerializeField] private bool _isMoving = false;//If the object is moving.

    private MovementHandler _movement;//the movement handler.
    
    /// <summary>
    /// The direction the object will move  in.
    /// </summary>
    public Vector3 direction
    {
        get { return _direction; }
        set { _direction = value; }
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
