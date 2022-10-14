using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class broomMove : MonoBehaviour
{
    private Vector3 broomStart;

    // Start is called before the first frame update
    void Start()
    {
        broomStart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = broomStart + new Vector3(0.0f, 0.3f * Mathf.Sin(Time.time), 0.0f); 
    }
    
}
