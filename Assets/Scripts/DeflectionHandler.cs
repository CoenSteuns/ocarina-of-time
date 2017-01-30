using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// handels the deflection from the charackters (not reusable)
/// </summary>
public class DeflectionHandler : MonoBehaviour
{
    [SerializeField] private float _range;
    [SerializeField] private string[] _acceptedTags;
    [SerializeField] private Color _color;

    private AreaObjectCalculator _object;
    private TargetHolder _target;

    void Awake()
    {
        _target = GetComponent<TargetHolder>();
        _object = GetComponent<AreaObjectCalculator>();
    }

    public void DeflectProjectiles()
    {
        GameObject[] objects = _object.GetObjectsInArea(_range, _acceptedTags);

        for (var i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<DeflectionManeger>().Bounce(_target.target);
            ParticleSystem.MainModule newMain = objects[i].GetComponent<ParticleSystem>().main;
            newMain.startColor = _color;
        }
    }
}
