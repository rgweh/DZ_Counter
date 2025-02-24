using System.Collections;
using TMPro;
using UnityEngine;

public class CounterUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMesh;
    [SerializeField] private Counter _counter;

    private Coroutine _coroutine;

    private void Update()
    {
        _textMesh.text = _counter.Number.ToString();
    }

    private void OnMouseUp()
    {
        if (_counter.IsWorking)
        {
            _counter.Pause();
            StopCoroutine(_coroutine);
        }
        else
        {
            _counter.Unpause();
            _coroutine = _counter.StartCounter();
        }
    }
}
