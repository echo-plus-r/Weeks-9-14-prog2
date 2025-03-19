using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG_clickToSpawn : MonoBehaviour
{
    public GameObject meal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 pos = new Vector2();
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(meal, pos, Quaternion.identity);
        }
        
    }
}
