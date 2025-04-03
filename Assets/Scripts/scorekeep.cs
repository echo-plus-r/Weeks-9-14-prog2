using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scorekeep : MonoBehaviour
{
    public balloon balloon;
    public spawningscript spawningscript;
    TMP_Text tmp;
    int score = 200;
    // Start is called before the first frame update
    void Start()
    {
        spawningscript.spawned.AddListener(MakeListener);
        balloon.tooBig.AddListener(popped);
        tmp = GetComponent<TMP_Text>();
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
    public void MakeListener(balloon nb)
    {
        // pray
        nb.tooBig.AddListener(popped);
    }
}
