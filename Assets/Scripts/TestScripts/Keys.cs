using System;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UIElements.Button;

[RequireComponent(typeof(Button))]

//code borrowed and modified by Warped Imagination on youtube https://www.youtube.com/watch?v=wsWeI7APjAU
public class Keys : MonoBehaviour
{
    [SerializeField] [Tooltip("Keycode representing a key")]
    private KeyCode keyCode = KeyCode.None;

    public Action<KeyCode> pressed;

    private void Awake()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnButtonClick);
        
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        
        if (text && string.IsNullOrEmpty(text.text))
        {
            text.text = keyCode.ToString();
        }
    }

    private void OnButtonClick()
    {
        pressed?.Invoke(keyCode);
    }
}
