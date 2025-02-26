using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _counterSpeed = 0.5f;
    [SerializeField] private CounterView _counterView;

    private int _number;
    private bool _isWorking;
    private Coroutine _coroutine;

    private void Start()
    {
        _number = 0;
        _isWorking = false;
        _counterView.UpdateText(_number);
    }

    private void OnMouseUp()
    {
        if (_isWorking)
        {
            _isWorking = false;
            StopCoroutine(_coroutine);
        }
        else
        {
            _isWorking = true;
            _coroutine = StartCoroutine(Countdown());
        }
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        while (true)
        {
            _number++;
            _counterView.UpdateText(_number);

            yield return wait;
        }
    }

}
