using UnityEngine;
using System.Collections;

public class ObjectFollow : MonoBehaviour {

	[SerializeField] private GameObject _target;

    private Vector3 diff;
    public Vector3 driffencePosition;

    void Start()
    {
        driffencePosition = _target.transform.position - transform.position;
    }

	// Update is called once per frame
	void Update () {
        diff = _target.transform.position - driffencePosition;
        transform.position = _target.transform.position - driffencePosition;
	}
}
