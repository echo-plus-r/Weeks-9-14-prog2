using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spawningscript : MonoBehaviour
{
    // this game object is what the spawner will spawn
    public GameObject balloon, newBalloon;
    public scorekeep scorekeep;
    public balloon balloonScript;

    public UnityEvent<balloon> spawned;


    // Update is called once per frame
    void Update()
    {
        // checks if the player is pressing the left mouse button down
        if (Input.GetMouseButtonDown(0))
        {
            // getting the mouse position and converting it into a world position
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // spawning a plant at the mouse position
            newBalloon = Instantiate(balloon, mousepos, Quaternion.identity);
            balloonScript = newBalloon.GetComponent<balloon>();
            spawned.Invoke(balloonScript);
            
        }
    }

}
