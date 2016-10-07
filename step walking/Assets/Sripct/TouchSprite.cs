using UnityEngine;
using System.Collections;

public class TouchSprite : MonoBehaviour {
	public static bool guiTouch = false;

	public void TouchInput (BoxCollider2D collider){
		if (Input.touchCount > 0) {
			if (collider == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
				switch (Input.GetTouch (0).phase) {
				case TouchPhase.Began:
					guiTouch = true;
					break;
				case TouchPhase.Stationary:
					guiTouch = true;
					break;
				case TouchPhase.Moved:
					guiTouch = true;
					break;
				case TouchPhase.Ended:
					guiTouch = false;
					break;
				}
			}
		}
		if (Input.touchCount > 1) {
			if (collider == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (1).position))) {
				switch (Input.GetTouch (1).phase) {
				case TouchPhase.Began:
					guiTouch = true;
					break;
				case TouchPhase.Stationary:
					guiTouch = true;
					break;
				case TouchPhase.Moved:
					guiTouch = true;
					break;
				case TouchPhase.Ended:
					guiTouch = false;
					break;
				}
			}
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
