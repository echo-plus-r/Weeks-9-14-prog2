using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class knight : MonoBehaviour
{
    Animator animaor;
    SpriteRenderer sr;
    public float speed = 2;
    public bool canRun = true;

    // Start is called before the first frame update
    void Start()
    {
        animaor = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        sr.flipX = (direction < 0);
        animaor.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButton(0))
        {
            canRun = false;
            animaor.SetTrigger("attack");
        
        }
        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }

        
        //transform.position += transform.right * direction * speed * Time.deltaTime;
    }
    public void AttackHasFinished()
    {
        Debug.Log("Ready to Run again");
        canRun = true;
    }
}
