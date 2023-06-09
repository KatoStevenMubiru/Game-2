using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerController : MonoBehaviour
{
    public float horizonatlInput;
    public float speed = 10.0f;
    private float xRange = 24.0f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonatlInput = Input.GetAxis("Horizontal");

        // Moves the player left and right
        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }else if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        transform.Translate(Vector3.right * horizonatlInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)){
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            

        }//if
    }
}
