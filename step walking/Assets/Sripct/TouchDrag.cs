using UnityEngine;
using System.Collections;

public class TouchDrag : MonoBehaviour {

	/*// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TouchInput (GetComponent<BoxCollider2D>());
	}
	void OnFirstTouch(){
		Vector3 pos;
		pos = new Vector3 (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x, Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y, transform.position.z);
		transform.position = pos;
	}*/

	Vector3 originalPos;
	public Vector3 truePos;
	public float minX, maxX, minY, maxY;
	float distance = 10;

	void Start () {
		originalPos = transform.position;
		Tresshold (0.3f,0.3f);
	}

	void OnMouseDown() {
		originalPos = transform.position;
	}

	void OnMouseDrag() {
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}

	void OnMouseUp() {
		if (transform.position.x < maxX && transform.position.x > minX && transform.position.y < maxY && transform.position.y > minY) {
			transform.position = truePos;
		} else {
			transform.position = originalPos;
		}
	}

	void Tresshold (float xx, float yy){
		minX = truePos.x - xx;
		maxX = truePos.x + xx;
		minY = truePos.y - yy;
		maxY = truePos.y + yy;
	}
}
