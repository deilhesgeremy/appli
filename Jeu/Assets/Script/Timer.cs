using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	float time;
	float tick;
	public float timerinterval = 5f;

	void Awake(){
		time = (int)Time.time;
	}

	void Update(){
		GetComponent<Text> ().text = time.ToString();

		time = (int)Time.time;

		if (time == tick) {
			tick = time + timerinterval;
			Debug.Log ("Timer");
		}

		if (time == 10) {
			
		}
	}

	void TimerExecute(){

	}
}
