using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class listen : MonoBehaviour {
	public AudioSource soundTarget;
	public AudioClip clipTarget;

	public void playSound(string ss){
		clipTarget = (AudioClip)Resources.Load(ss);
		soundTarget.clip = clipTarget;
		soundTarget.loop = false;
		soundTarget.playOnAwake = false;
		soundTarget.Play();

	}
}
