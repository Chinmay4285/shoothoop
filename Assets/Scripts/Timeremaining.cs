using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timeremaining : MonoBehaviour {
    Text text;
    Levelmanager levelmanager;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        levelmanager = FindObjectOfType<Levelmanager>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Time Remaining: " + (int)levelmanager.timetilnextlevel;
    }
}
