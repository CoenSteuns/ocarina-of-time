using System.Collections;
using UnityEngine.Events;
using UnityEngine;

/// <summary>
/// Just a timer.
/// </summary>
public class Timers
{
    private MonoBehaviour _monoBehaviour; //monobehavior used for the coroutine.

    private float _startTime;//the time the timer starts at
    private bool _repeate;//if the timer restarts itself
    private bool _isPaused;
    private float _currentTime;//the current time the timer is at

    private Coroutine _timerCoroutine;//the timerCoruotine

    public UnityEvent timedEvent;//The evnet which is invoked when the timer reaches 0

    /// <summary>
    /// The time the timer start at.
    /// </summary>
    public float StartTime
    {
        get { return _startTime; }
        set { _startTime = value; }
    }
    /// <summary>
    /// If the timer restarts itself.
    /// </summary>
    public bool Repeate
    {
        get { return _repeate; }
        set { _repeate = value; }
    }
    /// <summary>
    /// The current time.
    /// </summary>
    public float CurrentTime
    {
        get { return _currentTime; }
    }
    /// <summary>
    /// If the timer is paused.
    /// </summary>
    public bool IsPaused
    {
        get { return _isPaused; }
        set { _isPaused = value; }
    }

    //CSonstructor.
    public Timers(float startTime = 0, bool repeate = false, bool startImmediate = false, UnityEvent Event = null)
    {
        timedEvent = Event == null ? new UnityEvent() : Event;
        _startTime = startTime;
        _repeate = repeate;
        if (startImmediate){Start();}
    }

    /// <summary>
    /// Start the timer.
    /// </summary>
    public void Start()
    {
        if (_monoBehaviour == null)
        {
            _monoBehaviour = Object.FindObjectOfType<MonoBehaviour>();
            if (_monoBehaviour == null)
            {
                Debug.Log("y no monobehaviour?");
                return;
            }
        }
        _timerCoroutine = _monoBehaviour.StartCoroutine(TimerCoroutine());
    }

    /// <summary>
    /// Stops the timer.
    /// </summary>
    public void Stop()
    {
        _monoBehaviour.StopCoroutine(_timerCoroutine);
        _currentTime = 0;
    }

    /// <summary>
    /// The coroutine used for the timer.
    /// </summary>
    /// <returns></returns>
    private IEnumerator TimerCoroutine()
    {
        _currentTime = _startTime < 0 && _repeate ? 0.001f : _startTime;
        while (_currentTime > 0)
        {
            yield return null;
            if (_isPaused) { continue;}
            _currentTime -= Time.deltaTime;
        }
        timedEvent.Invoke();
        if (_repeate){Start();}
        _currentTime = 0;
    }

}

