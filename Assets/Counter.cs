using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _counterSpeed = 0.5f;

    public bool IsWorking = false;
    public int Number = 0;

    public Coroutine SetUpCourutine()
    {
        return StartCoroutine(Countdown());
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
