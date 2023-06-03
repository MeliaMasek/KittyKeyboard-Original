using TMPro;
using UnityEngine;

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU
public class Letter : MonoBehaviour
{
    private TextMeshProUGUI text = null;
    private char? Entry { get; set; } = null;

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        text.text = null;
    }

    public void EnterLetter(char c)
    {
        Entry = c;
        text.text = c.ToString().ToUpper();
    }

    public void DeleteLetter()
    {
        Entry = null;
        text.text = null;
    }

    public void Clear()
    {
        Entry = null;
        text.text = null;
    }
}
