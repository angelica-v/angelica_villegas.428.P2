using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherryPieButton : MonoBehaviour
{
    public GameObject CherryPiePrefab;

    // Start is called before the first frame update
    void Start()
    {
    }

      // void OnCollisionEnter(Collision collision) {
    private void OnTriggerEnter(Collider other){

        Instantiate(CherryPiePrefab);
     }
}
