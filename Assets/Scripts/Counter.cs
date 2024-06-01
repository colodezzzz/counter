using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour
{
    private const int MouseButtonNumber = 0;

    [SerializeField, Tooltip("Time to count in seconds")] private float _timeToCount;
    [Space]
    [SerializeField] private CounterIndicator _indicator;

    private int _amount;
    private WaitForSeconds _waitTime;
    private Coroutine _countingCoroutine;
    private bool _isCounting;

    private void Awake()
    {
        _waitTime = new WaitForSeconds(_timeToCount);
        _amount = 0;
        _indicator.SetAmount(_amount);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(MouseButtonNumber))
        {
            _isCounting = _isCounting == false;

            if (_isCounting)
            {
                StartCount();
            }
            else
            {
                StopCount();
            }
        }
    }

    private void StartCount()
    {
        if (_countingCoroutine == null)
        {
            _countingCoroutine = StartCoroutine(Counting());
        }
    }

    private void StopCount()
    {
        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);
            _countingCoroutine = null;
        }
    }

    private IEnumerator Counting()
    {
        while (_isCounting)
        {
            yield return _waitTime;

            _amount++;
            _indicator.SetAmount(_amount);
        }
    }
}
