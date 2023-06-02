using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU
public class LetterManager : MonoBehaviour
{
    [SerializeField] [Tooltip("Prefab for the letter")]
    private Letter letterPrefab = null;

    [SerializeField] [Tooltip("Amount of rows")]
    private int rows = 1;

    [SerializeField] [Tooltip("Grid Parent")]
    HorizontalLayoutGroup gridLayout = null;
    
    private List<Letter> letters = null;
    private const int wordLength = 7;
    private int index = 0;
    private int currentRow = 0;
    private char?[] guess = new char?[wordLength];

    private void Update()
    {
        if (Input.anyKeyDown)
            ParseInput(Input.inputString);
    }

    private void Awake()
    {
        GridSetup();
    }

    public void GridSetup()
    {
        if (letters == null)
            letters = new List<Letter>();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < wordLength; j++)
            {
                Letter letter = Instantiate(this.letterPrefab);
                letter.transform.SetParent(gridLayout.transform);
                letters.Add(letter);
            }
        }
    }

    public void ParseInput(string value)
    {
        foreach (char c in value)
        {
            if (c == '\b')
            {
                DeleteLetter();
            }
            else if ((c == '\n') || (c == 'r'))
            {
                GuessWord();
            }
            else
            {
                EnterLetter(c);
            }
        }
    }
    
    public void EnterLetter(char c)
    {
        if (index < wordLength)
        {
            c = char.ToUpper(c);
            
            letters[(currentRow * wordLength) + index].EnterLetter(c);
            guess[index] = c;
            index++;
        }
    }
    
    public void DeleteLetter()
    {
        if (index > 0)
        {
            index--;
            letters[(currentRow * wordLength) + index].DeleteLetter();
            guess[index] = null;
        }
    }
    
    public void GuessWord()
    {
        
    }
}
