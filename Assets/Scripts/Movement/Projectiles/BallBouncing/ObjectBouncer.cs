using UnityEngine;
using System.Collections;

public class ObjectBouncer : MonoBehaviour {

    [SerializeField] private GameObject targetOne;
    [SerializeField] private GameObject targetTwo;

    private ObjectTargetMovement _mover;

    void Awake()
    {
        _mover = GetComponent<ObjectTargetMovement>();
    }

    public void Bounce()
    {
        _mover.target = _mover.target == targetOne ? targetTwo : targetOne;
    }
}
