using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

    [SerializeField] private Camera _camera;                        // the camera
    [SerializeField] private float _shakeDuration = 2;              //the duration of the shakes;
    [SerializeField] private float _shakeIntensity = 0.05f;         //the intensity of the shaking
    [SerializeField] private float _shakeSpeed = 0.05f;             //the speed at which the camera will go to a new position
    [SerializeField] private bool _isShaking = true;                 //if the camera shake is on.

    private float _shakeLeft;                                       //how long it wil keep shaking.

    /// <summary>
    /// The start duration of a shake.
    /// </summary>
    public float shakeDuration
    {
        get { return _shakeDuration; }
        set { _shakeDuration = value; }
    }

    /// <summary>
    /// The speed at which the camera will go to a new position.
    /// </summary>
    public float shakeSpeed
    {
        get { return _shakeSpeed; }
        set { _shakeSpeed = value; }
    }
    /// <summary>
    /// The intensity of the shake.
    /// </summary>
    public float shakeIntansity
    {
        get { return _shakeIntensity; }
        set { _shakeIntensity = value; }
    }

    /// <summary>
    /// If the camera is shaking.
    /// </summary>
    public bool isShaking
    {
        get { return _isShaking; }
    }

    /// <summary>
    /// Resets the shake to full duration.
    /// </summary>
    public void ResetShake()
    {
        _shakeLeft = _shakeDuration;
    }

    /// <summary>
    /// Starts the screenshake.
    /// </summary>
    public void StartShake()
    {
        _isShaking = true;
        StartCoroutine(Shake());
    }

    /// <summary>
    /// Stops the screenshake.
    /// </summary>
    public void StopShake()
    {
        _isShaking = false;
    }

    void Start()
    {
        if (_isShaking)
            StartShake();
    }

    /// <summary>
    /// Shakes the object.
    /// </summary>
    /// <returns></returns>
    private IEnumerator Shake()
    {
        Vector3 startPosition = _camera.transform.localPosition;//the startposition
        
        while (true)
        {
            if (_shakeLeft > 0)
            {
                _camera.transform.localPosition = Random.insideUnitSphere * _shakeIntensity + startPosition;//makes the position a random position around the startposition
                _shakeLeft -= Time.deltaTime;//the duration minus the deltatime
                yield return new WaitForSeconds(_shakeSpeed);
            }
            else {
                _shakeLeft = 0.0f;//the shake is 0.
                _camera.transform.localPosition = startPosition;//sets the camera back to the start position.
                yield return null;
            }
            if (!_isShaking)
            {
                _camera.transform.localPosition = startPosition;
                break;
            }
        }
    }
}
