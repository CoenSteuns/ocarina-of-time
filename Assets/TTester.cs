using UnityEngine;

public class TTester : MonoBehaviour {

    public Timers t;
    public Timers b;


	// Use this for initialization
	void Start ()
	{
        b = new Timers(2,true);
        t = new Timers(2,true);
        t.timedEvent.AddListener(T);
	    t.IsPaused = true;
        t.Start();
	    //t = new Timers(2, true, true);
        //t.timedEvent.AddListener(T);
        //t.Start();
	}

    void T()
    {
        print("k");
    }
}
