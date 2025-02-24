using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _counterSpeed = 0.5f;

    public bool IsWorking { get; private set; }
    public int Number { get; private set; }

    public Coroutine StartCounter()
    {
        return StartCoroutine(Countdown());
    }

    public void Pause()
    {
        IsWorking = false;
    }
    
    public void Unpause()
    {
        IsWorking = true;
    }

    private void Start()
    {
        IsWorking = false;
        Number = 0;
    }

    private IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        for (int i = 0; i >= 0; i++)
        {
            Debug.Log(i);
            Number++;

            yield return wait;
        }
    }

}
