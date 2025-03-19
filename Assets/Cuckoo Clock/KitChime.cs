using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitChime : MonoBehaviour
{
    public KitClock Clcock;
    //private .on

    public void Update()
    {
        
    }
    public void Chime(int hour);
    {
    Debug.Log("Chiming !" + hour + "o'clock");
    }
}
