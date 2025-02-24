using System.Collections;
using TMPro;
using UnityEngine;

public class CounterUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMesh;
    [SerializeField] private Counter _counter;

    private void Start()
    {
        _counter.StartCounter();
    }
    private void Update()
    {
        _textMesh.text = _counter.Number.ToString();
    }

    private void OnMouseUp()
    {
        if (_counter.IsWorking)
            _counter.PauseCountdown();
        else
            _counter.UnpauseCountdown();
    }
}
