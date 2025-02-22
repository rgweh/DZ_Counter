using TMPro;
using UnityEngine;

public class CounterUpdater : MonoBehaviour
{
    [SerializeField] TextMeshPro _textMesh;

    public void UpdateCounter(int number)
    {
        _textMesh.text = number.ToString();
    }
}
