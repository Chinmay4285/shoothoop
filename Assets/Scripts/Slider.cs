using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour {
    public Slider slider;
    internal float value;
    float speed = 0;
	// Use this for initialization
	void Start () {
	
    }
	
	// Update is called once per frame
	void Update () {
        speed += Input.GetAxis("Mouse ScrollWheel");
        speed= Mathf.Clamp(speed, 0, 10);
       // print("speed is" + speed);
    }
}
