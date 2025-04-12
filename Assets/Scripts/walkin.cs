using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkin : MonoBehaviour
{
    Animator animaor;
    SpriteRenderer sr;
    AudioSource au;
    public float speed = 2;
    public AudioClip[] sounds;
    public AnimationCurve curve;
    float t = 1f;
    Vector2 start;
    bool jumping = false;
    // Start is called before the first frame update
    void Start()
    {
        animaor = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        au = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        float direction = Input.GetAxis("Horizontal");
        sr.flipX = (direction < 0);
        animaor.SetFloat("movement", Mathf.Abs(direction));
        if (Input.GetKeyDown("space") && !jumping)
        {
            t = 0f;
            start.y = pos.y;
            jumping = true;
            animaor.SetFloat("jumping", 1);
        }
        if (t < 1 && jumping)
        {
            pos.y = start.y + curve.Evaluate(t);
            t += 0.5f * Time.deltaTime;
        }
        else
        {
            jumping = false;
            animaor.SetFloat("jumping", 0);
        }
        transform.position = pos;
        transform.position += transform.right * direction * speed * Time.deltaTime;
    }
    public void step() 
    {
        au.clip = sounds[Random.Range(0, 9)];
        au.Play();
    }

    public void land()
    {

    }
}
