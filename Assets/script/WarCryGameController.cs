using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WarCryGameController : MonoBehaviour
{

	//PRIVATE INSTANCE VARIABLE
	private int _scoreValue;
	private int _livesValue;
	private int _bkgResetCount;

	//PUBLIC INSTANCE VARIABLE
	public Text scoreLabel;
	public Text livesLabel;
	public Text highScoreLabel;
	public Text highScoreLabelText;
	public Text gameOverLabel;

	public GameObject canvas;
	public GameObject scorePanel;
	public GameObject gameOverPanel;
	public GameObject menuPanel;

	//public access methods
	public int ScoreValue { 
		get {
			return _scoreValue; 
		} 
		set { 
			this._scoreValue = value;
			this.scoreLabel.text = "Score: " + this._scoreValue;
		} 
	}

	public int LivesValue { 
		get { 
			return _livesValue; 
		} 
		set { 
			this._livesValue = value;
			if (this._livesValue <= 0) {
				this._EndGame ();
			} else {
				this.livesLabel.text = "Lives: " + this._livesValue;
			}
		} 
	}

	public int BkgRestCount{
		get{
			return this._bkgResetCount;
		}
		set{
			this._bkgResetCount = value;
		}
	}

	// Use this for initialization
	void Start ()
	{
		this._initialize ();
		this.menuPanel.gameObject.SetActive(true);
		this.scorePanel.gameObject.SetActive (false);
		this.gameOverPanel.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	//Load Instruction Scene
	public void InstructionButtonClick(){
		SceneManager.LoadScene("Instructions");
	}

	//Load Level 1 Game Scene
	public void StartGameButtonClick(){
		DontDestroyOnLoad (this.canvas);
		this.menuPanel.gameObject.SetActive(false);
		this.scorePanel.gameObject.SetActive(true);
		SceneManager.LoadScene("main");
	}


	public void BackButtonClick()
	{
		SceneManager.LoadScene("Menu");
	}

	//Quit Game
	public void QuitButtonClick(){
		Application.Quit ();
	}

	//Load Settings Scene
	public void SettingsButtonClick(){
		SceneManager.LoadScene("Settings");
	}

	public void MenuButtonClick(){
		Destroy (this.canvas);
		Destroy (transform.gameObject);
		SceneManager.LoadScene ("Menu");
	}

	public void PlayAgainButtonClick(){
		this.menuPanel.gameObject.SetActive(false);
		this.scorePanel.gameObject.SetActive(true);
		this.gameOverPanel.SetActive (false);
		this._initialize ();
		SceneManager.LoadScene ("main");
	}

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}



	//PRIVATE METHODS
	private void _initialize ()
	{
		this.ScoreValue = 0;
		this.LivesValue = 10;
		this.gameOverLabel.text = "GAME OVER";
	}

	//END GAME
	public void _EndGame(){
		this.gameOverPanel.gameObject.SetActive(true);
		this.scorePanel.gameObject.SetActive (false);
		this.highScoreLabel.text = this._scoreValue.ToString();
		SceneManager.LoadScene ("GameOver");
	}
}
