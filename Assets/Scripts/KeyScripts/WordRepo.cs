using System;
using UnityEngine;
using Random = UnityEngine.Random;

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU
//code borrowed and modified by Zigurous on youtube https://www.youtube.com/watch?v=Tbcgqz5lM38

public class WordRepo : MonoBehaviour
{
    [SerializeField] [Tooltip("Word text files")]
    
    private string[] solutionsWords;
    private string[] validWords;
    private string word;
    private string jumbled;

    private void Start()
    {
        LoadData();
        SetRandomWord();
    }

    private void LoadData()
    {
        TextAsset textFile = Resources.Load("Seven_Letter_Words") as TextAsset;
        validWords = textFile.text.Split('\n');
        
        textFile = Resources.Load("Seven_Letter_Words") as TextAsset;
        solutionsWords = textFile.text.Split('\n');
    }

    public void SetRandomWord()
    { 
        word = solutionsWords[Random.Range(0, solutionsWords.Length)];
        word = word.ToUpper().Trim();

        
        jumbled = word;
        
        
        char[] myChar = jumbled.ToCharArray(); // Convert string to char array
        
        // Jumble char array 
        for (int i = myChar.Length - 1; i > 0; i--)
        {
                int rnd = Random.Range(0, i);
                (myChar[i], myChar[rnd]) = (myChar[rnd], myChar[i]);
                
                jumbled = new string(myChar);   // Convert char array to string 
                //jumbleWordText.text = word;   // Display jumbled word to screen
        }
        Debug.Log(jumbled);
        
    }
}
