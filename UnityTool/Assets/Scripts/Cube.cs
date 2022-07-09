using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cube : MonoBehaviour
{
    private void Start()
    {
        GenerateColor();
    }

    public void GenerateColor()
    {
        GetComponent<SpriteRenderer>().color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
