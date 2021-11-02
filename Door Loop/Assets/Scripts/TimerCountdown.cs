using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public GameObject Countdonw;
    public int secondsLeft = 10;
    public bool takingAway = false;

    private void Start()
    {
        Countdonw.GetComponent<Text>().text = secondsLeft + " Segundos";
    }
    private void Update()
    {
        if(takingAway == false && secondsLeft >= 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        Countdonw.GetComponent<Text>().text = secondsLeft + " Segundos";
        takingAway = false;
    }
}
