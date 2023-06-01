using System;
using UnityEngine;

//code borrowed and modified by Zigurous on youtube https://www.youtube.com/watch?v=Tbcgqz5lM38
public class InputBoxBehaviour : MonoBehaviour
{
    public InputFieldBehaviour[] tiles { get; private set; }

    private void Awake()
    {
        tiles = GetComponentInChildren<InputFieldBehaviour[]>();
    }
}
