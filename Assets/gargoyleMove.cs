using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gargoyleMove : MonoBehaviour
{
    private Vector3 gargoyleStart;
    float randomValue;
    
    // Start is called before the first frame update
    void Start()
    {
        gargoyleStart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position == gargoyleStart) {
           randomValue =  Random.Range(0.0f, 0.22f);
        }
        // 0.22 works
        transform.position = gargoyleStart + new Vector3(randomValue * Mathf.Sin(Time.time), 0.0f, 0.0f); 
    }
}
