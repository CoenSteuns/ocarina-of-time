using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[System.Serializable]
public class ColliderEvent : UnityEvent<GameObject> { };

public class CollisionHandler : MonoBehaviour {

    [SerializeField] private string[] _colliderTags;
    [SerializeField] private UnityEvent[] _collisionEvent;

    [SerializeField] private string[] _colliderTagsCollider;
    [SerializeField] private ColliderEvent[] _collisionEventCollider;

    void OnTriggerEnter(Collider other)
    {
        for(int i = 0; i < _colliderTags.Length; i++)
        {
            if (other.CompareTag(_colliderTags[i]))
            {
                _collisionEvent[i].Invoke();
            }
        }

        for (int i = 0; i < _colliderTagsCollider.Length; i++)
        {
            if (other.CompareTag(_colliderTagsCollider[i]))
            {
                _collisionEventCollider[i].Invoke(other.gameObject);
            }
        }
    }

}
