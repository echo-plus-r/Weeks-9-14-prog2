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

    //public UnityEvent OnTheHour;

    public UnityEvent<int> OnTheHour;

    Coroutine clockIsRunning;
    IEnumerator doingOneHourOfMovement;

    void Start()
    {
        clockIsRunning = StartCoroutine(MoveTheClock());
    }

    IEnumerator MoveTheClock() {

        while (true)
        {
            doingOneHourOfMovement = MoveTheClockHandsOneHour();
            yield return StartCoroutine(doingOneHourOfMovement);

        }
    }
    IEnumerator MoveTheClockHandsOneHour()
    {
        t = 0;
        while (t < timeAnHourTakes)
        {

            t += Time.deltaTime;
            minutehand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null;

        }
        hour++;
        if (hour == 13) 
        {
            hour = 1;
        }
        OnTheHour.Invoke(hour);
    }


    void Update()
    {

        t += Time.deltaTime;

        if (t > timeAnHourTakes)
        {
            t = 0;

            // below is the one line i can't figure out how to fix, hope thing still (mostly) work :3
            //OnTheHour.Invoke();
            hour++;
            if (hour == 12)
            {
                hour = 0;
            }
        }
    }
    
    public void StopTheClock() 
    {
        StopCoroutine(clockIsRunning);
        StopCoroutine(doingOneHourOfMovement);
    }
}
