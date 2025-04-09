using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alpha_triangle13 : MonoBehaviour
{
    Vector2 mousepos, pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos = transform.position;
        pos.x += (mousepos.x / 5) * Time.deltaTime;
        pos.y += (mousepos.y / 5) * Time.deltaTime;
        transform.position = pos;
    }
}
