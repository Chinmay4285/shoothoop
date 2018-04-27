using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour {
   public int score = 0;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Incrementscore(int scoreperhit)
    {
        score += scoreperhit;
        print("Your Current Score is " + score );
    }
}
