using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindow : EditorWindow
{
    private bool _toggle = false;
    
    [MenuItem("Window/My CustomWindow")]
    public static void ShowWindow()
    {
        GetWindow<CustomWindow>();
    }

    private void OnGUI()
    {
        GUILayout.Label("라?벨", EditorStyles.boldLabel);

        _toggle = EditorGUILayout.Toggle("토글", _toggle);
    }
}
