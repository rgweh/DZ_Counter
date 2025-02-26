using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMesh;

    public void UpdateText(int number)
    {
        _textMesh.text = number.ToString();
    }
}
