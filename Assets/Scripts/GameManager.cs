using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float Restartdelay = 1.5f;
	public GameObject CompleteLevelUI;
	public void CompleteLevel() 
	{
		CompleteLevelUI.SetActive(true);
	}
	public void EndGame()
	{
		if(gameHasEnded == false) 
		{
			gameHasEnded = true;
			Debug.Log("Game Over!");
			Invoke("Restart", Restartdelay);
		}
	}
	public void Restart() 
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
