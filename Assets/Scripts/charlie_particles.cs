using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charlie_particles : MonoBehaviour
{
    ParticleSystem pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // should be called when the mouse is hovering over a specified ui element
    public void hover()
    {
        pc.Play();
    }

    public void halt()
    {
        pc.Stop();
    }
}
