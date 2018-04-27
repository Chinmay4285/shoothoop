using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
   public GameObject ballprefab;
	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        float speed = 5.0f;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           // Instantiate(ballprefab);
            GameObject instance = Instantiate(ballprefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * speed ;

        }else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Instantiate(ballprefab);
            GameObject instance = Instantiate(ballprefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * speed;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Instantiate(ballprefab);
            GameObject instance = Instantiate(ballprefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * speed;

        }
        else if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate(ballprefab);
            GameObject instance = Instantiate(ballprefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;

        }




    }
}
