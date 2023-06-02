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

    [SerializeField] [Tooltip("Word Repo")]
    private WordRepo wordRepo = null;
    
    private List<Letter> letters = null;
    private const int wordLength = 4;
    private int index = 0;
    private int currentRow = 0;
    private char?[] guess = new char?[wordLength];
    private char[] wordchar = new char[wordLength];

    private void Update()
    {
        if (Input.anyKeyDown)
            ParseInput(Input.inputString);
    }

    private void Awake()
    {
        GridSetup();
    }

    private void Start()
    {
        SetWord();
    }

    public void SetWord()
    {
        string word = wordRepo.RandomWord();
        for (int i = 0; i < word.Length; i++)
            wordchar[i] = word[i];
    }

    public string GetWord()
    {
        return new string(wordchar);
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
            else if ((c == '\n') || (c == '\r'))
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
        if (index != wordLength)
        {
            //Animation
        }
        else
        {
            if (wordRepo.CheckWord(wordchar.ToString()))
            {
                bool incorrect = false;

                for (int i = 0; i < wordLength; i++)
                {
                    bool correct = guess[i] == wordchar[i];

                    if (!correct)
                    {
                        incorrect = true;

                        bool letterExists = false;

                        for (int j = 0; j < wordLength; j++)
                        {
                            letterExists = guess[i] == wordchar[j];
                            if (letterExists)
                            {
                                break;
                            }   
                        }
                    }
                }
            }
        }
    }
}
