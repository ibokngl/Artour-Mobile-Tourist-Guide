using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbutton : MonoBehaviour {

	public void Update () {

		if (Application.platform == RuntimePlatform.Android) {

			if (Input.GetKeyUp(KeyCode.Escape)) {

				//quit application on return button

				Application.LoadLevel(2);

				return;

			}

		}

	}

}

