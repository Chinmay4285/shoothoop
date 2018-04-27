using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    Text text;
    Scorekeeper scorekeeper;
	// Use this for initialization
	void Start () {
        scorekeeper = FindObjectOfType<Scorekeeper>();
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: "+ scorekeeper.score;
		
	}
}
