using UnityEngine;
using System.Collections;

public class Hinge : MonoBehaviour {
	//public objects
	public Transform _player;
	public GameController _gameController;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			this._player.transform.position = new Vector2 (0f, 0f);
		//	Destroy (other.gameObject);
			this._gameController.LivesValue--;
		}

		//	this._lives--;

	}
}
