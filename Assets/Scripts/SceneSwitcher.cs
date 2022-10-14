using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{

	public int currentScene;

	// Start is called before the first frame update
	void Start()
	{
		DontDestroyOnLoad(this.gameObject);

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.anyKey)
		{
			currentScene++;
			if (currentScene == SceneManager.sceneCountInBuildSettings)
			{
				currentScene = 0;
			}
			SceneManager.LoadScene(currentScene);
			
		}

	}
}
