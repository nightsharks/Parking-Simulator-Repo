using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject pauseObject;
    

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
	}	

    public void showPaused()
    {
        pauseObject.SetActive(true);
    }

    public void hidePaused()
    {
        pauseObject.SetActive(false);
    }

    public void pause()
    {
        Time.timeScale = 0;
    }

    public void resume()
    {
        Time.timeScale = 1;
    }

}
