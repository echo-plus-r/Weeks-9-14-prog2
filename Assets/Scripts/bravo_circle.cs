using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bravo_circle : MonoBehaviour
{
    Coroutine SizeChange;
    public Slider slider;
    Vector2 scale;

    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener(StartChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartChange(float x)
    {
        SizeChange = StartCoroutine(SC(x));
    }
    IEnumerator SC(float change) {
        while(transform.localScale.x > change)
        {
            scale = transform.localScale;
            scale.x -= 0.1f * Time.deltaTime;
            scale.y -= 0.1f * Time.deltaTime;
            transform.localScale = scale;
        }
        while (transform.localScale.x < change)
        {
            scale = transform.localScale;
            scale.x += 0.1f * Time.deltaTime;
            scale.y += 0.1f * Time.deltaTime;
            transform.localScale = scale;
        }
        yield return null;
    }
}
