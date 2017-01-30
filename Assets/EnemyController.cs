using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private ConstantVelocity _move;
    private Timers _timer;

	// Use this for initialization
	void Start ()
	{
	    _move = GetComponent<ConstantVelocity>();
	    _timer = new Timers(3);
	}

    public void Hit()
    {
        _move.StartMoving();
    }

    public void Fly()
    {
        _move.StartMoving();
    }


    public void landed()
    {
        _move.StopMoving();
        _move.SetDirection(-_move.Direction);  
        _timer.timedEvent.AddListener(Fly); 
        _timer.Start();
    }
}
