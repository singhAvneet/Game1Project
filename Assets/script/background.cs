using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed ;
	private AudioSource[] audioSources;
	private AudioSource music;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();

		// Reset the Ocean Sprite to the Top
		this.Reset ();
		//initialize the audio sources array
		this.audioSources = gameObject.GetComponents<AudioSource> ();
		this.music = this.audioSources [0];
		this.music.Play ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this._currentPosition -= new Vector2(this.speed,0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x <= -1700) {
			this.Reset ();
		}





	}

	public void Reset() {
		this._transform.position = new Vector2 (40f,0);
	}
}
