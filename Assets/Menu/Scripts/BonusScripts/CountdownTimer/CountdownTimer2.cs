using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer2 : MonoBehaviour {
	public string levelToLoad;
	private float timer = 400f;
	private Text timerSeconds;

	// Use this for initialization
	void Start ()
	{
		timerSeconds = GetComponent<Text> ();	
	}

	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		timerSeconds.text = timer.ToString ("f0");
		if (timer <= 0) 
		{
			SceneManager.LoadScene(levelToLoad);
			Cursor.visible = true;
		}
	}
}
