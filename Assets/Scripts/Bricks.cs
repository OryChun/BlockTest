using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public int maxHits = 1;
	public int timesHit;
	
	void OnCollisionEnter2D (Collision2D collision)
	{
		timesHit++;
	}

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timesHit == maxHits){
			Destroy(this);
		}
	}
}
