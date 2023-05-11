using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int positionX = 20;
    int positionY = 0;
    int positionZ = 30;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S)){

           int animalIndex = Random.Range(0, 4);
           Vector3 Positions =new Vector3(Random.Range(-positionX, positionX),positionY,positionZ);
       
       Instantiate(animalPrefabs[animalIndex], Positions, animalPrefabs[animalIndex].transform.rotation);

        }//if


    }
}
