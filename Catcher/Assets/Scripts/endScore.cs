using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endScore : MonoBehaviour
{
    public TextMeshPro points;

    void Start()
    {
        points.text = "Score: " + GameController.score;
    }
}
