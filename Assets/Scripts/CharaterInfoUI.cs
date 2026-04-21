using UnityEngine;
using TMPro;
using System;

public class CharacterInfoUI : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField birthYearInput;
    public TMP_Text resultText;

    public void ShowInfo()
    {
        string playerName = nameInput.text;

        if (string.IsNullOrWhiteSpace(playerName))
        {
            resultText.text = "Lūdzu ievadi tēla vārdu!";
            return;
        }

        if (!int.TryParse(birthYearInput.text, out int birthYear))
        {
            resultText.text = "Lūdzu ievadi korektu dzimšanas gadu!";
            return;
        }

        int age = DateTime.Now.Year - birthYear;

        if (age < 0)
        {
            resultText.text = "Dzimšanas gads nav pareizs!";
            return;
        }

        resultText.text = $"Supervaronis {playerName} ir {age} gadus vecs!";
    }
}