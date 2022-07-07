using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class ToolKitLearn : EditorWindow
{
    [MenuItem("QuickTool/Open")]
    private static void ShowWindow()
    {
        ToolKitLearn window = GetWindow<ToolKitLearn>();

        window.titleContent = new GUIContent("ToolKitLearn");

        window.minSize = new Vector2(280, 50);

    }

    private void CreateGUI()
    {
        VisualElement root = rootVisualElement;

        Button myButton = new Button() {text = "My Button"};

        myButton.style.width = 160;
        myButton.style.height = 30;
        
        root.Add(myButton);
    }
}
