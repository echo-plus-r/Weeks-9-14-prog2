using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alpha_cube13 : MonoBehaviour
{
    SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpriteRenderer.color = Random.ColorHSV();
        }
    }
}
