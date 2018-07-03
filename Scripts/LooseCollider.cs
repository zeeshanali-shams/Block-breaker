using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {
	private LevelManager levelmanager;
	void OnTriggerEnter2D(Collider2D trigger){
		levelmanager=GameObject.FindObjectOfType<LevelManager>();
		print ("Trigger");
		levelmanager.LoadLevel("Loose");
	}
	void OnCollisionEnter2D(Collision2D collision){
		print ("collision");
	}
}
