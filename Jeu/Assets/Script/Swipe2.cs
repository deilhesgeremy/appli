using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Moved) || (Input.GetMouseButton(1))){
			Plane ObjPlane1 = new Plane(Camera.main.transform.forward*-1, this.transform.position);

			Ray mRay1 = Camera.main.ScreenPointToRay(Input.mousePosition);
			float rayDistance1;
			if(ObjPlane1.Raycast(mRay1, out rayDistance1)){
				this.transform.position = mRay1.GetPoint(rayDistance1);
			}
		}
	}
}
