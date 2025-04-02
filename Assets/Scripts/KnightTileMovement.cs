using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class KnightTileMovement : MonoBehaviour
{
    public Tilemap tm;
    public Tile grass;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.GetMouseButtonDown(0)) 
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int gridpos = tm.WorldToCell(mousepos);

            Debug.Log(gridpos);

            if (tm.GetTile(gridpos) == grass)
            {
                Debug.Log("DON'T STEP ON THE GRASS");
            }
            else 
            {
                pos = gridpos;
            }
            transform.position = pos;
        }   

    }
}
