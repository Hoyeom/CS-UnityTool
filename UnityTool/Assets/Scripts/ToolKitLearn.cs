using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class ToolKitLearn : EditorWindow
{

    private Color _copyColor = Color.black;
    
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

        Label title = new Label("Color Picker");
        ColorField colorField = new ColorField();
        
        container.Add(title);
        container.Add(colorField);

        VisualElement buttonsContainer = new VisualElement();

        Button randomColorButton =  CreateButton("Random Color",()=>colorField.value = RandomColor());
        Button resetColorButton = CreateButton("Reset Color",()=>colorField.value = Color.black);
        Button copyColorButton = CreateButton("Copy Color",()=>  _copyColor = colorField.value);;
        Button pasteColorButton = CreateButton("Paste Color", () => colorField.value = _copyColor);

        buttonsContainer.Add(randomColorButton);
        buttonsContainer.Add(resetColorButton);
        buttonsContainer.Add(copyColorButton);
        buttonsContainer.Add(pasteColorButton);
        
        container.Add(buttonsContainer);
    }

    private Button CreateButton(string text,Action action = null)
    {
        Button button = new Button() {text = text};
        button.clicked += action;
        return button;
    }

    private Color RandomColor()
    {
        return Random.ColorHSV(0, 1, 0, 1, 0, 1, 1, 1);
    }
    
}
