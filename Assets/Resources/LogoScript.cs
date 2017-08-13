using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine ("Countdown");
	}

    private IEnumerator Countdown()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel(2);
    }
	
}
