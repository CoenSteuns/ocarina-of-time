using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class CollisionHandler : MonoBehaviour {

    [SerializeField] private UnityEvent _obstacleHit;

    void Update()
    {
        
    }


    
    void OnTriggerEnter(Collider other)
    {
        print("l");
        if (other.CompareTag("Obstacle"))
        {
            print("k");
            _obstacleHit.Invoke();
        }
    }
}
