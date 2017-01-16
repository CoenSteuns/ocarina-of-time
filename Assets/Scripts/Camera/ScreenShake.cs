using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

    [SerializeField] private Camera _camera;                        // the camera
    [SerializeField] private float _shakeDuration = 2;              //the duration of the shakes;
    [SerializeField] private float _shakeIntensity = 0.05f;         //the intensity of the shaking
    [SerializeField] private float _shakeSpeed = 0.05f;             //the speed at which the camera will go to a new position
    [SerializeField] private bool _isShaking = true;                 //if the camera shake is on.

    private float _shakeLeft;                                       //how long it wil keep shaking.
    private bool _shakeBreak = true;

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
    /// Starts the screenshake.
    /// </summary>
    public void StartShake()
    {
        if(!_isShaking)
            StartCoroutine(Shake());
    }

    /// <summary>
    /// Stops the screenshake.
    /// </summary>
    public void StopShake()
    {
        _shakeBreak = false;
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
        _shakeLeft = _shakeDuration;//reset the shake
        Vector3 startPosition = _camera.transform.localPosition;//the startposition
        Vector3 positionDiffrence = Vector3.zero;//new vector with position (0,0,0)
        do
        {
            _isShaking = false;//turns the shaking off
            if (_shakeLeft > 0)//if the time left is more then 0
            {

                //the shaking
                startPosition = _camera.transform.localPosition - positionDiffrence;
                _camera.transform.localPosition = Random.insideUnitSphere * _shakeIntensity + startPosition;
                positionDiffrence = _camera.transform.localPosition - startPosition;

                _shakeLeft -= Time.deltaTime;//subtracts the time
                _isShaking = true;//turns shaking on
            }
            yield return new WaitForSeconds(_shakeDuration);//what if duration
        } while (isShaking && _shakeBreak);//repeat if is shaking
        _camera.transform.localPosition = startPosition;//if the shaking is over return to the center position
        _shakeBreak = true;

    }
}
