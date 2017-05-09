using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchButton : Button {

	public string SceneName;

	void OnTouchUp(){
		SceneManager.LoadScene (SceneName);
	}
}
