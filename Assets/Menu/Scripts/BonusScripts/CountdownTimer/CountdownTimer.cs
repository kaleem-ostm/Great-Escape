using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour {
	public string levelToLoad;
	public float timer = 300f;
	public Text timerSeconds;

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
		}
	}
}
