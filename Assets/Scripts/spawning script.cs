using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningscript : MonoBehaviour
{
    public GameObject balloon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // getting the mouse position and converting it into a world position
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // spawning a plant at the mouse position
            Instantiate(balloon, mousepos, Quaternion.identity);
        }
    }

}
