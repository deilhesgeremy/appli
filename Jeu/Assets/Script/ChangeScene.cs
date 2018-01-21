using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public string sceneNameToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	//Appelée par un bouton
	public void changeScene(){

		SceneManager.LoadScene (sceneNameToLoad);

	}
}
