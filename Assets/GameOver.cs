using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private UnityEvent _deathEvent;
    [SerializeField] private Health _health;

    void Awake()
    {
        _health = GetComponent<Health>();
    }

    public void CheckGameOver()
    {
        if (_health.currentHealth < _health.minHealth)
        {
            _deathEvent.Invoke();
        }
    }

}
