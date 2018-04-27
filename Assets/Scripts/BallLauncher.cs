using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallLauncher : MonoBehaviour
 {
   // public Slider slider1;
    public GameObject ballprefab;
    public float ballspeed = 1.0f;
    
    private Vector3 throwSpeed = new Vector3(0, 26, 40);
    // Use this for initialization
    void Start () {

    }


    // Update is called once per frame
    void Update()
    {
        //  for (ballspeed = 3; Input.anyKeyDown; ballspeed++) ;
        ballspeed += Input.GetAxis("Mouse ScrollWheel");
        ballspeed = Mathf.Clamp(ballspeed, 0, 10);
        print("speed is" + ballspeed);
        //slider1.value = ballspeed;

        if (Input.GetMouseButtonUp(0))
        {
            // Instantiate(ballprefab);
            GameObject instance = Instantiate(ballprefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            // throwSpeed.x = ballspeed/2;
            throwSpeed.y = ballspeed / 2;
            throwSpeed.z = (ballspeed);
            rb.velocity = camera.transform.rotation * throwSpeed * ballspeed;
             //ballspeed = 3.0f;


        }
    }
   

}

   

