using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private CounterUpdater _counterUpdater;
    [SerializeField] private float _counterSpeed = 0.5f;

    private int _number = 0;
    private bool _isWorking = false;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    private void OnMouseUp()
    {
        Debug.Log("pressed");

        if (_isWorking)
            _isWorking = false;
        else
            _isWorking = true;
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        for (int i = 0; i >= 0; i++)
        {
            if (_isWorking)
            {
                _number++;
                _counterUpdater.UpdateCounter(_number);

                yield return wait;
            }
            else
                yield return null;
        }
    }
}
