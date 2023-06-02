using TMPro;
using UnityEngine;

// code borrowed and modified by Jayanam on youtube https://www.youtube.com/watch?v=xpcyZdyO5P8
public class ButtonText : MonoBehaviour
{
    public TextMeshProUGUI textField;

    public void SetText(string text)
    {
        textField.text = text;
    }
}
