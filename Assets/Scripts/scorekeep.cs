using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scorekeep : MonoBehaviour
{
    // honestly i don't know if i need this
    public balloon balloon;

    // a refrence to the spawning script, used to make a listener for the object
    public spawningscript spawningscript;

    // variable that holds it's own text component.
    TMP_Text tmp;

    // int that holds the score.
    float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        // adding a listener for the spawning script, should run every time a new balloon is spawned.
        spawningscript.spawned.AddListener(MakeListener);

        // i don't think this is needed
        //balloon.tooBig.AddListener(popped);

        // getting the text component.
        tmp = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // this function runs every time a balloon is popped
    public void popped(float type)
    {

        // multiplying inputted score by 10, adding it to the score, then rounding the score.
        score = Mathf.Round(score + (type * 10));

        // updating the score.
        tmp.SetText(score.ToString());
    }

    // this function runs every time a balloon is spawned
    // it adds a new listener to itself to listen to events from the new balloon
    public void MakeListener(balloon nb)
    {
        nb.ChangeScore.AddListener(popped);
    }
}
