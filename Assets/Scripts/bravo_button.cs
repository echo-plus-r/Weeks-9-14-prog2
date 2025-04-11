using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bravo_button : MonoBehaviour
{
    // go is the GameObject we will spawn
    public GameObject go;

    // pos holds where the object will be spawned
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        // randomizing the x position
        pos.x = Random.Range(0, Camera.main.pixelWidth);

        //randomizing the y position
        pos.y = Random.Range(0, Camera.main.pixelHeight);

        // converting the values of pos to a world point
        pos = Camera.main.ScreenToWorldPoint(pos);

        // instantiating the object
        Instantiate(go, pos, Quaternion.identity);
    }
}
