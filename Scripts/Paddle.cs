using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoplay=false;
	private Ball ball;
	// Use this for initialization

	// Update is called once per frame
	void Start(){
		ball=GameObject.FindObjectOfType<Ball>();
	}
	void Update () {
		if (!autoplay) {
			MoveWithMouse ();
		} else {
			Autoplay();
		}
	}
	void Autoplay(){
		Vector3 padllePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		padllePos.x = Mathf.Clamp(ballPos.x,0.5f,15.5f);
		this.transform.position = padllePos;
	}
	void MoveWithMouse(){
		Vector3 padllePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		padllePos.x = Mathf.Clamp(mousePosInBlocks,0.5f,15.5f);
		this.transform.position = padllePos;
	}
}
