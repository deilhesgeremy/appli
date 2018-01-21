using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {

	float time;
	float tick;
	public float timerinterval = 5f;

	public UnityEngine.UI.Text clickDisplay;
	public UnityEngine.UI.Text timerDisplay;
	public UnityEngine.UI.Text scoreDisplay;

	public float click = 0;
	public float freqclic;
	public float clickp = 1;

	void Awake(){
		
	}
	void Start(){
		time = (int)Time.time;
	}

	void Update(){
		//clickDisplay.text = "Clic(s): " + click;

		if (time <= 10) {
			timerDisplay.text = "Time: " + time;
		}
		//GetComponent<Text> ().text = time.ToString();

		time = (int)Time.time;

		if (time == tick) {
			tick = time + timerinterval;
			Debug.Log ("Timer");
		}

		if (time == 10) {
		}
	}

	public void Clicked(){
		if (time < 10) {
			click = click + clickp;
		} else {
			scoreDisplay.text = "Score: " + click / 10 + " click/s";

		}
	}
}
