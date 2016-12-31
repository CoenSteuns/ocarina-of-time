using UnityEngine;
using System.Collections;

/// <summary>
/// Makes objects look at other objects.
/// </summary>
public class CameraLookAt : MonoBehaviour {


    [SerializeField] private Transform _target;        //the transform the object will look at.
    [SerializeField] private float _speed = 5;         //the speed at which the object will turn.

    private Vector3 _oldTarget;                        //the old target
    private float _offset = 0.1f;                      

    /// <summary>
    /// The transform the object has to look towards.
    /// </summary>
    public Transform target
    {
        get { return target; }
        set
        {
            _oldTarget = _target.position;
            _target = value;
        }
    }

    /// <summary>
    /// The speed at which the object turns (0 is instant).
    /// </summary>
    public float speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    /// <summary>
    /// The minimum distance from the target before it starts looking at the target.
    /// </summary>
    public float offset
    {
        get { return _offset; }
        set { _offset = value; }
    }

    void Start()
    {
        _oldTarget = _target.position;//sets the old target so the game starts looking at the target.
    }

	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(TurnCalculator());//turns the object
	}

    /// <summary>
    /// Calculates the position the object has to look at.
    /// </summary>
    /// <returns>The position the object has to look towards.</returns>
    private Vector3 TurnCalculator()
    {
        Vector3 lookat;
        //got a warning "_oldTarget != null" will always be true
        if (_oldTarget != null && (_target.position - _oldTarget).magnitude > _offset && _speed != 0)//checks if there is an old target, if it isn't already looking at the target and if it should be instant
        {
            _oldTarget += (_target.position - _oldTarget).normalized * _speed * Time.deltaTime;//moves the target a little.
            lookat = _oldTarget;
        }
        else
        {
            _oldTarget = _target.position;
            lookat = _target.position;//Looks at new target.
        }
        return lookat;//returns the position.
    }
}
