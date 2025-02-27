using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMesh;
    [SerializeField] private Counter _counter;

    private void Start()
    {
        _counter.CounterUpdate += OnCounterUpdate;
    }

    private void OnCounterUpdate(int number)
    {
        _textMesh.text = _counter.Number.ToString();
    }
}
