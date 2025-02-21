using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshPro _textMesh;
    [SerializeField] private float _counterSpeed = 0.5f;

    private int _number = 0;
    private bool _isWorking = false;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isWorking)
            {
                _isWorking = false;
            }
            else
            {
                _isWorking = true;
                StartCoroutine(Countdown());
            }
        }
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        for (int i = 0; _isWorking; i++)
        {
            _number++;
            UpdateCounter(_number);
            yield return wait;
        }
    }

    private void UpdateCounter(int number)
    {
        _textMesh.text = Convert.ToString(number);
    }
}
