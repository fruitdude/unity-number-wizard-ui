using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour{
    [SerializeField] int maximum_number;
    [SerializeField] int minimum_number;
    [SerializeField] TextMeshProUGUI guess_number_text;
    int guessed_number;
    
    void Start() {
        StartInstructions();
    }

    void StartInstructions() {
        NextGuess();
    }


    void NextGuess() {
        guessed_number = Random.Range(minimum_number, maximum_number + 1);
        guess_number_text.text = guessed_number.ToString();
    }

    public void OnPressHigher() {
        minimum_number = guessed_number + 1;
        NextGuess();
    }

    public void OnPressLower() {
        maximum_number = guessed_number - 1;
        NextGuess();
    }
}
