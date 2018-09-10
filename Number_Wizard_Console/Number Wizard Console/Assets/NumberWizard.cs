using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    private void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Max number that can be entered is " + max);
        Debug.Log("Min number that can be entered is " + min);
        Debug.Log("Initial guess is " + guess);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("up pressed");
            min = guess;
            guess = (max + guess) / 2;
            Debug.Log("New guess: " + guess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("down pressed");
            max = guess;
            guess = (min + guess) / 2;
            Debug.Log("New guess: " + guess);
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            Debug.Log("Right answer guessed!");
            StartGame();
        }
	}
}
