using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RulesPage : MonoBehaviour {

	public void GoBack()
	{
		SceneManager.LoadScene("StartPage");

	}
}
