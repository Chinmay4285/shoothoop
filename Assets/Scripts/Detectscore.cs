using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectscore : MonoBehaviour {
    public int scoreperhit = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        Scorekeeper scorekeeper = FindObjectOfType<Scorekeeper>();
        scorekeeper.Incrementscore(scoreperhit);
    }
}
