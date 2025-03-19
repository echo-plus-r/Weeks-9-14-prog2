using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minutehand;
    public float timeAnHourTakes = 5;

    public float t;
    public int hour = 0;

    public UnityEvent OnTheHour;

    public UnityEvent<in> OnTheHour;

    Coroutine clockIsRunning;
    Coroutine doingOneHourOfMovement;

    void Start()
    {
        clockIsRunning = startCountline
//yield return StartCoroutine(Moveclockandhour());
    }

    IEnumerator MoveTheClock() {

        while (true)
        {
            doingOneHourOfMovement = MoveTheClockHandsOneHour();
            yield return StartCoroutine(Moveclockandhour());

        }
    }


    void Update()
    {

        t += Time.deltaTime;

        if (t > timeAnHourTakes)
        {
            t = 0;

            OnTheHour.Invoke();
            hour++;
            if (hour == 12)
            {
                hour = 0;
            }
        }
    }
    IEnumerator Moveclockandhour()
    {
        t = 0;
        while (t < timeAnHourTakes) {

            t += Time.deltaTime;
            minutehand.Rotate(0, 0, (360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, (360 / timeAnHourTakes) * Time.deltaTime);
            yield return null;
            
        }
        OnTheHour.Invoke(hour);
    }
    public void StopTheClock() 
    {
        StopCoroutine
    }
}
