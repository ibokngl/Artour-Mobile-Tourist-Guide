using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Visible : MonoBehaviour {

	public Image panel;

	void Start(){
		panel.gameObject.SetActive (false);
	}

}
