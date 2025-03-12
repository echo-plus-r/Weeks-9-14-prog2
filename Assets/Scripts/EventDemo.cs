using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        // no clue what the below line does or if it's actually needed 
        //OnTimerEnd.AddListener(MouseExit);
        t += Time.deltaTime;
        if (t > timelen) 
        {
            OnTimerEnd.Invoke();
            Debug.Log("SOMETHING HAPPENED!");
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
