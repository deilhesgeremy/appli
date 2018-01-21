﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || (Input.GetMouseButton(0))){
			Plane ObjPlane = new Plane(Camera.main.transform.forward*-1, this.transform.position);

			Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			float rayDistance;
			if(ObjPlane.Raycast(mRay, out rayDistance)){
				this.transform.position = mRay.GetPoint(rayDistance);
			}
		}


	}
}
