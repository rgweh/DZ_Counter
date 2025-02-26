using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _counterSpeed = 0.5f;

    public int Number { get; private set; }

    private bool _isWorking;
    private Coroutine _countdown;

    private void OnMouseUp()
    {
        if (_isWorking)
            StopCoroutine(_countdown);
        else
            _countdown = StartCoroutine(Countdown());

        _isWorking = !_isWorking;
    }
    public void StartCounter()
    {
        Number = 0;
        _isWorking = true;
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        while (enabled)
        {
            Number++;

            yield return wait;
        }
    }

}
