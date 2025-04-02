using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scorekeep : MonoBehaviour
{
    public balloon balloon;
    TextMeshPro tmp;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        balloon.tooBig.AddListener(popped);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void popped()
    {
        Debug.Log("pong");
        score -= 100;
        tmp.SetText(score.ToString());
    }
}
