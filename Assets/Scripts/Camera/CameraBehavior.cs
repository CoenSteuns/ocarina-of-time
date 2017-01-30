using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private float _sideDistance;
    [SerializeField] private float _backDistance;
    [SerializeField] private float _ground;
    [SerializeField] private float _addedY;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _target;
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(_player.transform.position + (_target.transform.position - _player.transform.position) / 2);

	    var position = _player.transform.position + _player.transform.right * _sideDistance + _player.transform.forward * -_backDistance;

	    position.y = (_target.transform.position.y + ((_player.transform.position - _target.transform.position).normalized *
	                              ((_player.transform.position - _target.transform.position).magnitude + _addedY)).y);
	    if (position.y < _ground)
	    {
	        position = new Vector3(transform.position.x,_ground,transform.position.z);
	    }
	    transform.position = position;
	    //transform.position = new Vector3(transform.position.x, position.y , transform.position.z);
	}
}
