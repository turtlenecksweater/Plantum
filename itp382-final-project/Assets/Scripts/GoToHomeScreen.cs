﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHomeScreen : MonoBehaviour {

	public void GoHome() {
		SceneManager.LoadScene ("LaunchScene");
	}
}