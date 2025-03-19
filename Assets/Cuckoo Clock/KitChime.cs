using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public KitClock Clock;

    private void Start()
    {
        Clock.OnTheHour.AddListener(Chime);
    }

    public void Update()
    {
        
    }
    public void Chime(int hour)
    {
        Debug.Log("Chiming !" + hour + "o'clock");
    }
    public void ChimeWithoutArguments() 
    {
        Debug.Log("It's chime time baby!");
    }
}
