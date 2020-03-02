using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	//score of player
	public int score = 0;

	//lives for player
	public static int playerhp = 100;

	//high score for the game
	public int highScore = 0;

	//current level
	public static int currentLevel = 1;

	//number of levels
	public int highestLevel = 6;

	public static int savedLevel;

	public static int savePoints = 6;

	public int armor = 0;

	public bool golfy = false;

	public bool resetball = false;

	public SimpleHealthBar healthBar;

	public AudioSource deathsound;


//HUDManager hud; 

	//instance of the GM that can be accessed from anywhere
	public static GameManager instance;

	void Awake(){
		//check to see if instance has been assigned
		if (instance == null) {
			//assign it to the current object
			instance = this;
		}
		//make sure that is equal to the current object
		else if (instance != this) {

//instance.hud = FindObjectOfType<HUDManager> ();

			//we do not need one so destroy it
			Destroy(gameObject);
		}

		//dont destroy this object when changing scenes
		DontDestroyOnLoad(gameObject);

//hud = FindObjectOfType<HUDManager> ();

	}

	public void Update () {
		healthBar.UpdateBar ( playerhp, 100 );
	
	}
		

	//decrease lives by 1
	public void DecreaseLives(){
		/* *if (currentLevel == 4) {
			playerhp = playerhp - 2 + armor;
		} else { */
			playerhp = playerhp - 5 + armor;
		/*} */
	
//hud.ResetHud ();

		if (playerhp == 0) {
			SceneManager.LoadScene ("gameover");
		}
		if (playerhp <= 20) {
			healthBar.UpdateColor( Color.red );
		}
	}

	//game reset
	public void ResetGame(){

		//reset the score
		score = 0;

		//reset number of lives
		playerhp = 100;

		//current level to 1
		currentLevel = 1;

		//update score and lives text
//hud.ResetHud ();

		//load first level
		SceneManager.LoadScene("level1");


	}

	//send player to next level
	public void IncreaseLevel(){

		//check for next level
		if (currentLevel < highestLevel) {

			//increase level by 1
			currentLevel++;
		} else {
			currentLevel = 1;
		}

		//load next level
		SceneManager.LoadScene("level"+currentLevel);
	}

	public static void SaveLevel() {
		if (savePoints > 0) {
			savedLevel = currentLevel;
			savePoints = savePoints - 1;
		}
	}

	public void YouWin(){
		if (currentLevel == 6) {
			//SceneManager.LoadScene("win");
		}
	}

	public void ToLastSaved() {
		SceneManager.LoadScene ("level" + savedLevel);
	}

	public void ToTutorial() {
		SceneManager.LoadScene ("Tutorial");
	}

	public void ToHome() {
		SceneManager.LoadScene ("homescreen");
		golfy = false;
	}

	public void DeathSound() {
		deathsound.Play ();
	}

	public void winner() {
		SceneManager.LoadScene ("winscreen");
	}

	public void ToGolf() {
		SceneManager.LoadScene ("Golf");
	
	}

	public void level2() {
		SceneManager.LoadScene ("level2");

	}
	public void level3() {
		SceneManager.LoadScene ("level3");

	}
	public void level4() {
		SceneManager.LoadScene ("level4");

	}
	public void level5() {
		SceneManager.LoadScene ("level5");

	}
	public void addplayerhp() {
		playerhp = playerhp + 10;
		healthBar.UpdateBar ( playerhp, 100 );

	}
}