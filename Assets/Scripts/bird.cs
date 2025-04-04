using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    // refrence to the spawning script. this is used so we can know when a balloon is spawned
    public spawningscript spawningscript;

    // pos holds the object's position
    Vector3 pos;

    // speed holds how fast the bird moves
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // adding a listener that listens to the spawner
        spawningscript.spawned.AddListener(MakeListener);   
    }

    // Update is called once per frame
    void Update()
    {

        // checks if the bird is off the right side of the screen
        if (transform.position.x > 10)
        {
            // teleports the bird to off the left side of the screen
            pos.x = -11;
            transform.position = pos;
        }

        // getting the object's position and setting it as pos
        pos = transform.position;

        // adding to pos based on speed
        pos.x += speed * Time.deltaTime;

        // setting the object's position
        transform.position = pos;
    }

    // this function slows the bird down, it's called when a balloon is popped.
    // note that this function takes a float that it does not use, this is because the ChangeScore event passes a float.
    // i decided to just not use the float instead of make a whole new event, as it would keep thing simple with only a single event the balloon sends out when it's popped.
    public void speedChange(float x)
    {
        speed -= 0.5f;
    }

    // this is mostly copied over from the spawning scorekeep script
    // this function runs every time a balloon is spawned
    // it adds a new listener to itself to listen to events from the new balloon, it also speeds up the bird.
    public void MakeListener(balloon nb)
    {
        speed += 0.5f;
        nb.ChangeScore.AddListener(speedChange);
    }

}
