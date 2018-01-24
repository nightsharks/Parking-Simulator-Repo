using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameLoops : MonoBehaviour {

    public GameObject x;
    public GameObject y;

	public void onWin()
    {
       x.SetActive(true);
    }

    public void onLoss()
    {
       y.SetActive(true);
    }
}
