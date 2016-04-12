using UnityEngine;
using System.Collections;

public class GroundEnemyDestroy : MonoBehaviour {
	public GameObject blast;
	private AudioSource[] audioSources;
	private AudioSource explosion;
	private int lives = 5;
	// Use this for initialization
	void Start () {
	//	this.explosion = gameObject.GetComponents<AudioSource> ();
//		this.explosion = this.audioSources [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "playerBullet"&& this.lives<0){
			Instantiate (blast, other.transform.position, other.transform.rotation);
			//Destroy (other.gameObject);
			Destroy (this.gameObject);
			//this.explosion.Play();
		}
		this.lives -= 1;

	}
}
