using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {

    [SerializeField] private string[] _destroyingColliders;
    [SerializeField] private float _waitBeforeDestroy;
    [SerializeField] private UnityEvent _destroyEvent;


	void OnTriggerEnter(Collider other)
    {
        foreach (string colliderName in _destroyingColliders)
        {
            if (other.CompareTag(colliderName))
            {
                _destroyEvent.Invoke();
                Destroy(this.gameObject, _waitBeforeDestroy);
            }
        }
    }
}
