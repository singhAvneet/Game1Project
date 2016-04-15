using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour
{
	//public gameObjects

	//private variables
	private Transform _transform;
	private AudioSource[] audioSources;
	private AudioSource coins;
	private AudioSource blast;
	private WarCryGameController _WarCryGameController;


	// Use this for initialization
	void Start ()
	{
		this._initialize ();
	}

	void Update ()
	{

		//Debug.Log (score);
	}

	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.CompareTag ("Coins")) {
			this._WarCryGameController.ScoreValue += 100;
			this.coins.Play ();
		}
		if (other.gameObject.CompareTag ("MiniEnemy")) {
			this._WarCryGameController.LivesValue--;
			this.blast.Play ();
		}
		if (other.gameObject.CompareTag ("EnemyBullet")) {
			
			this._WarCryGameController.LivesValue--;
			Destroy (other.gameObject);
			this.blast.Play ();
		}
	}

	private void _initialize ()
	{
		this._transform = gameObject.GetComponent<Transform> ();
		this._WarCryGameController = GameObject.Find ("WarCryGameContoller").GetComponent<WarCryGameController> ();

		//initialize the audio sources array
		this.audioSources = gameObject.GetComponents<AudioSource> ();
		this.coins = this.audioSources [1];
		this.blast = this.audioSources [0];
	}
}