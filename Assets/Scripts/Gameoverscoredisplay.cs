using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameoverscoredisplay : MonoBehaviour {
    Text text;
    Scoreabsorber scoreabsorber;
    // Use this for initialization
    void Start () {
        scoreabsorber = FindObjectOfType<Scoreabsorber>();
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Your Score is: " + scoreabsorber.score;
    }
}
