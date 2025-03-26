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
        float direction = Input.GetAxis("Horizontal");
        sr.flipX = (direction < 0);
        animaor.SetFloat("movement", Mathf.Abs(direction));
        

        transform.position += transform.right * direction * speed * Time.deltaTime;
    }
    public void step() 
    {
        au.clip = sounds[Random.Range(0, 9)];
        au.Play();
    }
}
