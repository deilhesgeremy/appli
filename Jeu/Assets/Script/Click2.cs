using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click2 : MonoBehaviour {
	float time;
	float tick;
	public int r = 0;
	public float timerinterval = 5f;
	public UnityEngine.UI.Text click2Display;
	public UnityEngine.UI.Text clickJ1Display;
	public UnityEngine.UI.Text clickJ2Display;
	public UnityEngine.GameObject BJ1;

	public GameObject BJ2;

	void Start(){
		

	}

	void Awake(){

		r = Random.Range(5, 16);
		time = (int)Time.time;
	}

	void Update(){

		//GetComponent<Text> ().text = time.ToString();
		time = (int)Time.time;

		if (time == tick) {
			tick = time + timerinterval;
		}

		if (time == r) {
			click2Display.text = "GO !";
		}
	}

	public void ClickedJ1(){
		if (time >= r) {
			click2Display.text = "J1 gagne";
			clickJ1Display.text = "J1 gagne !";

		} else {
			click2Display.text = "J1 gagne";
			clickJ1Display.text = "J1 perd !";

		}
	}

	public void ClickedJ2(){
		if (time >= r) {
			click2Display.text = "J1 gagne";
			clickJ2Display.text = "J2 gagne !";

		} else {
			click2Display.text = "J1 gagne";
			clickJ2Display.text = "J2 perd !";

		}
	}
}
