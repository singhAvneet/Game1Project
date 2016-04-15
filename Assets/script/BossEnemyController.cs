using UnityEngine;
using System.Collections;

public class BossEnemyController : MonoBehaviour {
	
	//PUBLIC VARIABLE
	public float speed;
	public GameObject enemyBullet;

	//PRIVATE VARIABLE
	private Transform _transform;
	private Transform _enemyBulletTransform;
	private Vector2 _currentPosition;
	//private int _liveScore;
	private int _bulletPositionY;

	// Use this for initialization
	void Start () {

		this._transform = gameObject.GetComponent<Transform> ();
		this._enemyBulletTransform = this.enemyBullet.gameObject.GetComponent<Transform> ();
		//this._liveScore = 10;
		this._bulletPositionY = 28;
		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;

		if (this._currentPosition.x == 205) {
			//Call the bullet coroutine
			StartCoroutine(EnemyBulletWaves());
		}

		if (this._currentPosition.x > 200) {
			this._currentPosition -= new Vector2 (this.speed, 0f);
			this._transform.position = this._currentPosition;
		}

		if (this._currentPosition.x <= 200) {
			// Move on Y axis
			//this._currentPosition -= new Vector2 (0.0f, 2.0f);
		}

	}

	IEnumerator EnemyBulletWaves(){
		//yield return new WaitForSeconds (5);
		while (true) {
			for (int i = 0; i < 2; i++) {
				this._enemyBulletTransform.position = new Vector2 (this._transform.position.x, this._transform.position.y + this._bulletPositionY);
				Instantiate (this.enemyBullet);
				this._bulletPositionY -= 56;
			}
			this._bulletPositionY = 28;
			yield return new WaitForSeconds (1);
		}
	}

	//PIVATE METHODS
	private void _Reset(){
		this._transform.position = new Vector2 (440f, 0f);
	}
		
}
