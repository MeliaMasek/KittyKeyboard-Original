using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU

public class WordRepo : MonoBehaviour
{
    [SerializeField] [Tooltip("Word text files")]
    private TextAsset wordlist = null;

    private List<string> words = null;

    private void Awake()
    {
        words = new List<string>(wordlist.text.Split(new char[] {',', ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries));
    }

    public string RandomWord()
    {
        return words[Random.Range(0, words.Count)];
    }

    public bool CheckWord(string word)
    {
        return words.Contains(word);
    }
}
