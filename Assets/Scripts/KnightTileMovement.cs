using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class KnightTileMovement : MonoBehaviour
{
    public Tilemap tm;
    public Tile grass;
    LineRenderer lr;
    Vector3 pos;
    Coroutine moving;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        
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
                lr.SetPosition(0, pos);
                moving = StartCoroutine(walkin(pos, gridpos));
                //pos = gridpos;
                lr.SetPosition(1, pos);
            }
            //transform.position = pos;
        }   

    }
    // no idea if this will work
    IEnumerator walkin(Vector3 pos, Vector3Int gridpos)
    {
        float t = 0f;
        while (pos != gridpos)
        {
            pos = Vector3.Lerp(pos, gridpos, t);
            transform.position = pos;
            t += 0.1f * Time.deltaTime;
            yield return null;
        }
        
    }
}
