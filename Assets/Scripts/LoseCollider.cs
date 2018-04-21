using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnCollisionEnter2D (Collision2D collision)
	{
		// object will stop at collision
		print ("collision");
	}
	
	void OnTriggerEnter2D (Collider2D trigger)
	{
		// object will pass collider
		// print ("triggering");
		levelManager.LoadLevel("Win Screen");
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
