﻿using UnityEngine;
using System.Collections;

public class enemyBounceController : MonoBehaviour {

    [SerializeField] private float _hitChance;

    private DeflectionHandler _bouncer;

    void Awake()
    {
        _bouncer = GetComponent<DeflectionHandler>();
        StartCoroutine(hit());
    }
	

    private IEnumerator hit()
    {
        float random;
        while (true)
        {
            random = Mathf.Round(Random.Range(0, 100));

            if (random > _hitChance)
            {
                _bouncer.DeflectProjectiles();
            }
            yield return new WaitForSeconds(0.33f);
        }
       
    }
}
