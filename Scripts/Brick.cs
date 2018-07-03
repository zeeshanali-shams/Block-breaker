using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int breakableCount=0;
	public AudioClip crack;

	private int timesHit;
	private bool isBreakable;
	private LevelManager levelmanager;	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableCount++;
		}
		timesHit = 0;
		levelmanager=GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(){
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable){
			HandleHits();
		}
	}
	void HandleHits(){
		timesHit = timesHit + 1;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			breakableCount--;
			levelmanager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		}
	}
	void SimulateWin(){
		levelmanager.LoadNextLevel ();
	}
}
