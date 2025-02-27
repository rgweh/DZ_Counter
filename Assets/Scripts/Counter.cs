using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _counterSpeed = 0.5f;

    private bool _isWorking;
    private Coroutine _countdown;

    public event Action<int> CounterUpdate;
    public int Number { get; private set; }

    public void Start()
    {
        Number = 0;
        _isWorking = false;
    }

    private void OnMouseUp()
    {
        if (_isWorking)
            StopCoroutine(_countdown);
        else
            _countdown = StartCoroutine(Countdown());

        _isWorking = !_isWorking;
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        while (enabled)
        {
            Number++;
            CounterUpdate?.Invoke(Number);

            yield return wait;
        }
    }

}
