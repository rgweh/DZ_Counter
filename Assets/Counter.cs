using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _counterSpeed = 0.5f;

    public bool IsWorking { get; private set; }
    public int Number { get; private set; }

    public void StartCounter()
    {
        StartCoroutine(Countdown());
    }

    public void PauseCountdown()
    {
        IsWorking = false;
    }
    
    public void UnpauseCountdown()
    {
        IsWorking = true;
    }

    private void Start()
    {
        IsWorking = false;
        Number = 0;
    }

    public IEnumerator Countdown()
    {
        var wait = new WaitForSeconds(_counterSpeed);

        for (int i = 0; i >= 0; i++)
        {
            if (IsWorking)
            {
                Number++;

                yield return wait;
            }
            else
                yield return null;
        }
    }

}
