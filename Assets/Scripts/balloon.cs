using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class balloon : MonoBehaviour
{
    // this coroutine happens in the start function
    Coroutine wakeup;
    Vector3 siz = new Vector3(1, 1, 1);
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        wakeup = StartCoroutine(grow());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StopAllCoroutines();
            StartCoroutine(fly());
        }
    }

    IEnumerator fly()
    {
        while (true)
        {
            pos = transform.position;
            pos.y += 1;
            transform.position = pos;
        }
    }
        IEnumerator grow() 
    {
        while (true)
        {
            transform.localScale += siz * Time.deltaTime;
            if (transform.localScale.x >= 20)
            {
                Debug.Log("the balloon is supposed to pop, yet it has not :/");
            }
            yield return null;
        }
    }
}
