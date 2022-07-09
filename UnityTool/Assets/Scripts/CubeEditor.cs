using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
    
    [CustomEditor(typeof(Cube))]
    public class CubeEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            Cube cube = (Cube) target;
            
            GUILayout.BeginHorizontal();
            
            if (GUILayout.Button("Random Color"))
                cube.GenerateColor();
            if(GUILayout.Button("Reset"))
                cube.Reset();
            
            GUILayout.EndHorizontal();
        }
    }
}