using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelmanager : MonoBehaviour {
   public float timetilnextlevel = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timetilnextlevel > 0)
        { timetilnextlevel -= Time.deltaTime;
            if (timetilnextlevel < 0)
                LoadNextScene();
        }   
	}
   public void LoadNextScene()
    {
        int currentindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentindex + 1);

    }
    public void LoadPreviousScene()
    {
        int currentindex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentindex - 1);

    }
}
