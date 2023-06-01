using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//code borrowed and modified by Zigurous on youtube https://www.youtube.com/watch?v=Tbcgqz5lM38
public class InputFieldBehaviour : MonoBehaviour
{
    private TextMeshProUGUI text;
    public char letter { get; private set; }
    
    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void SetLetter(char letter)
    {
        this.letter = letter;
        text.text = letter.ToString();
    }
        
    
}
