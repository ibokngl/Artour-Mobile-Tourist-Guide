using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aspect : MonoBehaviour {

	float width=800f;
	float height=1280f;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Camera> ().aspect = (width / height) * (Screen.width / Screen.height);
	}

}
