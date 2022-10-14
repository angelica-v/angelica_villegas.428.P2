using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffeeAdd : MonoBehaviour
{
    public GameObject CoffeeCupPrefab;
    public Vector3[] options;
    // Start is called before the first frame update
    void Start()
    {
        options = new Vector3[4];
        options[0] = new Vector3(0.502f, -1.568f,2.616f); 
        options[1] = new Vector3(0.681f, -1.568f, 2.616f); 
        options[2] = new Vector3(0.87f, -1.568f, 2.616f); 
        options[3] = new Vector3(1.039f, -1.568f, 2.616f); 
    }

      // void OnCollisionEnter(Collision collision) {
    private void OnTriggerEnter(Collider other){

        Instantiate(CoffeeCupPrefab,options[Random.Range(0,3)], Quaternion.identity);
     }
 }
