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
        VisualElement container = new VisualElement();

        rootVisualElement.Add(container);

        Label title = new Label("UI Elements");
        Label biggerTitle = new Label("Bigger Title");
        
        container.Add(biggerTitle);
        container.Add(title);



    }
}
