using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMesh;
    [SerializeField] private Counter _counter;

    public void Update()
    {
        _textMesh.text = _counter.Number.ToString();
    }
}
