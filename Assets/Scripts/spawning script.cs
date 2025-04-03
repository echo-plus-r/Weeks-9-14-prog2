using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spawningscript : MonoBehaviour
{
    // balloon is what the spawner will spawn
    // newBalloon is a refrence to the most recently spawned balloon
    public GameObject balloon, newBalloon;

    // this holds the part of a newly spawned balloon that we want to pass to the scorekeep script so it can add a listener to itself
    public balloon balloonScript;

    // event that runs whenever a balloon is spawned, listened to by the scorekeep script
    public UnityEvent<balloon> spawned;


    // Update is called once per frame
    void Update()
    {
        // checks if the player is pressing the left mouse button down
        if (Input.GetMouseButtonDown(0))
        {
            // getting the mouse position and converting it into a world position
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // spawning a plant at the mouse position and defininng newBalloon
            newBalloon = Instantiate(balloon, mousepos, Quaternion.identity);

            // getting a refrence to the balloon component for balloonScript
            balloonScript = newBalloon.GetComponent<balloon>();

            // invoking the spawning event and passing the script refrence
            spawned.Invoke(balloonScript);
            
        }
    }

}
