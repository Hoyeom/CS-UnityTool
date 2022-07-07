using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindow : EditorWindow
{
    [MenuItem("Window/My CustomWindow")]
    public static void ShowWindow()
    {
        GetWindow<CustomWindow>();
    }
}
