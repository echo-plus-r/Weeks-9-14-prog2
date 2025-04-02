using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scorekeep : MonoBehaviour
{
    public balloon balloon;
    TMP_Text tmp;
    int score = 200;
    // Start is called before the first frame update
    void Start()
    {
        balloon.tooBig.AddListener(popped);
        tmp = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.SetText(score.ToString());
    }

    public void popped()
    {
        Debug.Log("pong");
        score -= 100;
        
    }
}
