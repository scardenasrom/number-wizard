using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int lastGuess = 0;
    int currentGuess = 0;
    bool gameEnded = false;

	// Use this for initialization
	void Start () {
        InitializeGame();
    }

    void InitializeGame() {
        gameEnded = false;
        min = 1;
        max = 1000;
        lastGuess = 0;
        currentGuess = 0;
        print("Welcome to Number Wizard");
        print("Pick a number between " + min + " and " + max + ", but don't tell me");
        PrintGuess();
    }

    void PrintGuess() {
        currentGuess = (min + max) / 2;
        if (lastGuess == currentGuess) {
            currentGuess++;
        }
        print("Is the number higher or lower than " + currentGuess + "?");
        print("Up arrow for higher, down arrow for lower, return for equals");
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
            lastGuess = currentGuess;
            min = (min + max) / 2;
            PrintGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            lastGuess = currentGuess;
            max = (min + max) / 2;
            PrintGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            if (!gameEnded) {
                print("I won!");
                gameEnded = true;
                print("Press return if you want to play another round");
            } else {
                InitializeGame();
            }
        }
	}
}
