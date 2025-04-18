using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class balloon : MonoBehaviour
{
    // this coroutine happens in the start function
    Coroutine wakeup;

    // siz is short for size and holds how much is added to the size/scale of the object
    Vector3 siz = new Vector3(1, 1, 1);

    // pos is short for position and holds the position
    Vector3 pos;

    // this event runs when the balloon pops from being too big.
    public UnityEvent<float> ChangeScore;

    // Start is called before the first frame update
    void Start()
    {
        // runs a corotune when the scripts first starts
        // note to self: this is a special case, you wouldn't normally start a coroutine on wake up
        wakeup = StartCoroutine(grow());
    }

    // Update is called once per frame
    void Update()
    {
        // checks if the mouse button is up
        if (Input.GetMouseButtonUp(0))
        {
            // stops all coroutines attached to the object, which is only the grow one
            StopAllCoroutines();

            // this code did not work
            //wakeup = StartCoroutine(fly());

            // starting a new coroutine that handles the balloon's movement
            StartCoroutine(fly());
        }
    }

    // the coroutine that handles the balloon's upwards movement
    IEnumerator fly()
    {
        while (true)
        {
            if (transform.position.y > 8)
            {
                // invoking the ChangeScore event and passing the local scale
                ChangeScore.Invoke(transform.localScale.x);

                // making the balloon destroy itself
                Destroy(gameObject);
            }
            // sets pos to the object's position
            pos = transform.position;

            // add's to pos' y value
            pos.y += 2.0f * Time.deltaTime;

            // sets the object's position as pos.
            transform.position = pos;
            yield return null;
        }
    }

    // the coroutine that handles the balloon growing when the player first spawns one.
    IEnumerator grow() 
    {
        while (true)
        {
            // adding on to the local scale
            transform.localScale += siz * Time.deltaTime;

            // check if the balloon is over 3 units
            if (transform.localScale.x >= 3)
            {
                // invoking the ChangeScore event and passing -1
                ChangeScore.Invoke(-1);

                // having the balloon destroy itself
                Destroy(gameObject);
            }
            yield return null;
        }
    }
}
