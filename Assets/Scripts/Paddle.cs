using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float MousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		Vector3 paddlePos = new Vector3 (Mathf.Clamp(MousePosInBlocks, 0.5f, 15.5f), this.transform.position.y, 0f);
		// paddlePos.x = Mathf.Clamp(MousePosInBlocks, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}
}
