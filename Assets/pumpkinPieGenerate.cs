using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkinPieGenerate : MonoBehaviour
{
    public GameObject PumpkinPiePrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

      // void OnCollisionEnter(Collision collision) {
    private void OnTriggerEnter(Collider other){

        Instantiate(PumpkinPiePrefab);
     }
}
