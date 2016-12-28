using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private Transform _target;        //the transform the camera will look at.
    private Transform _oldTarget;                      //the old target
    /// <summary>
    /// The transform the camera has to look towards.
    /// </summary>
    public Transform target
    {
        get { return target; }
        set { _target = value; }
    }

    void Awake()
    {
        _oldTarget = this.transform;
        _oldTarget.forward += new Vector3(1,0,0);
    }
    
	// Update is called once per frame
	void Update () {
        Vector3 lookat;
        lookat = _oldTarget.position;
        lookat += (_target.position - _oldTarget.position).normalized * speed;
        transform.LookAt(lookat);
	}
}
