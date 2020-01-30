using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighscoresController : MonoBehaviour
{
    public TextMeshPro high1;
    public TextMeshPro high2;
    public TextMeshPro high3;
    public TextMeshPro high4;
    public TextMeshPro high5;
    public int highScore1;
    public int highScore2;
    public int highScore3;
    public int highScore4;
    public int highScore5;
    string highScoreKey1 = "HighScore1";
    string highScoreKey2 = "HighScore2";
    string highScoreKey3 = "HighScore3";
    string highScoreKey4 = "HighScore4";
    string highScoreKey5 = "HighScore5";

    void Start()
    {
        highScore1 = PlayerPrefs.GetInt(highScoreKey1, 0);
        high1.text = "" + highScore1;

        highScore2 = PlayerPrefs.GetInt(highScoreKey2, 0);
        high2.text = "" + highScore2;

        highScore3 = PlayerPrefs.GetInt(highScoreKey3, 0);
        high3.text = "" + highScore3;

        highScore4 = PlayerPrefs.GetInt(highScoreKey4, 0);
        high4.text = "" + highScore4;

        highScore5 = PlayerPrefs.GetInt(highScoreKey5, 0);
        high5.text = "" + highScore5;
    }
}
