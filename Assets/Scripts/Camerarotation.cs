using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerarotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        float rotationspeed = 3.0f;
        float mousex = Input.GetAxis("Mouse X")*rotationspeed;
        //float mousey = Input.GetAxis("Mouse Y")*rotationspeed;
        transform.localRotation = Quaternion.Euler(0, mousex, 0)* transform.localRotation;
        //print(mousey);
        Camera camera = GetComponentInChildren<Camera>();
         camera.transform.localRotation= Quaternion.Euler(0,0, 0) * camera.transform.localRotation;
      //  transform.localRotation = Quaternion.Euler(0,0, mousey) * transform.localRotation;
    }
}
 