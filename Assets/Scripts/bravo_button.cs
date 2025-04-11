using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bravo_button : MonoBehaviour
{
    // go is the GameObject we will spawn
    public GameObject go, newgo;

    public Slider sl;

    public bravo_circle BC;

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
        newgo = Instantiate(go, pos, Quaternion.identity);
        BC = newgo.GetComponent<bravo_circle>();
        BC.slider = sl;
    }
}
