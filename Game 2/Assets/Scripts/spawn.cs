using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] animalPrefabs;
   public int positionX = 20;
    public int positionY = 0;
   public  int positionZ = 30;
   public float startDelay = 2;
   public float spawnInterval = 1.5f;
    //public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("randomAnimal", startDelay, spawnInterval);   
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S)){

                randomAnimal();
         
        }//if


    }
    void randomAnimal(){

  int animalIndex = Random.Range(0, 4);
           Vector3 Positions =new Vector3(Random.Range(-positionX, positionX),positionY,positionZ);
       
       Instantiate(animalPrefabs[animalIndex], Positions, animalPrefabs[animalIndex].transform.rotation);


    }//randomAnimal
}
