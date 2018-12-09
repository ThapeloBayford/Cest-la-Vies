﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {

	public void ShowRules()
	{
		SceneManager.LoadScene("Rules");

	}
		public void ShowSpin()
	{
		SceneManager.LoadScene("Spin");

	}
		public void ShowAction()
	{
		SceneManager.LoadScene("Action");

	}
		public void ShowResult()
	{
		SceneManager.LoadScene("Result");

	}
		public void ShowStart()
	{
		SceneManager.LoadScene("StartPage");

	}
}
