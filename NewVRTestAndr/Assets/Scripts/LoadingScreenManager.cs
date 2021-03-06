using UnityEngine;
using System.Collections;

public class LoadingScreenManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadNextSceneAsync ();
	}
	
	private void LoadNextSceneAsync()
	{
		string sceneName = SceneManaging.SceneToLoad;
		UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (sceneName);
	}
}
