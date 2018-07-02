﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Exit() {
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
