using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreabsorber : MonoBehaviour {
    public int score;
	// Use this for initialization
	void Start () {
        Scorekeeper oldkeeper = FindObjectOfType<Scorekeeper>();
        score = 1;
        if (oldkeeper)
        {
            score = oldkeeper.score;
            Destroy(oldkeeper);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
