using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S)){
       
       Instantiate(animalPrefabs[1], new Vector3(0,0,30), animalPrefabs[1].transform.rotation);

        }//if


    }
}
