using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG_meal : MonoBehaviour
{
    public Transform top;
    public Transform mid;
    public Transform bot;

    Coroutine spin;
    // Start is called before the first frame update
    void Start()
    {
        spin = StartCoroutine(spin_forever());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spin_forever()
    {
        while (true)
        {
            top.Rotate(0, 0, (200 * Time.deltaTime));
            mid.Rotate(0, 0, (200 * Time.deltaTime));
            bot.Rotate(0, 0, (200 * Time.deltaTime));
            yield return null;
        }
    }
}
