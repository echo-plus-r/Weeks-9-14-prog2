using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public RectTransform image;

    public UnityEvent OnTimerEnd;
    public float timelen = 2;
    public float t;

    private void Update()
    {
        t += Time.deltaTime;
        if (t > timelen) 
        {
            OnTimerEnd.Invoke();
            t = 0;
        }
        //else
        //{
        //    OnTimerEnd.Invoke();
       // }

    }
    public void MouseEnter()
    {
        image.localScale = Vector2.one * 1.2f;
    }
    public void MouseExit()
    {
        Debug.Log("ER");
    }
}
