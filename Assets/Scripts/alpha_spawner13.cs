using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alpha_spawner13 : MonoBehaviour
{
    // what the spawner will spawn
    public GameObject spawn;
    CinemachineImpulseSource ImpulseSource;
    // Start is called before the first frame update
    void Start()
    {
        ImpulseSource = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            ImpulseSource.GenerateImpulse();
            Instantiate(spawn, (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
        }
    }
}
