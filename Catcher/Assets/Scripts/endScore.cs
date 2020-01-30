using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endScore : MonoBehaviour
{
    public TextMeshPro points;
    public TextMeshPro highscoretext;
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
        points.text = "Score: " + GameController.score;
        highScore1 = PlayerPrefs.GetInt(highScoreKey1, 0);
        highScore2 = PlayerPrefs.GetInt(highScoreKey2, 0);
        highScore3 = PlayerPrefs.GetInt(highScoreKey3, 0);
        highScore4 = PlayerPrefs.GetInt(highScoreKey4, 0);
        highScore5 = PlayerPrefs.GetInt(highScoreKey5, 0);
        if (GameController.score > highScore1)
        {
            highscoretext.text = "New Highscore!";
            PlayerPrefs.SetInt(highScoreKey1, GameController.score);
            PlayerPrefs.SetInt(highScoreKey2, highScore1);
            PlayerPrefs.SetInt(highScoreKey3, highScore2);
            PlayerPrefs.SetInt(highScoreKey4, highScore3);
            PlayerPrefs.SetInt(highScoreKey5, highScore4);
            PlayerPrefs.Save();
        }

        else if (GameController.score > highScore2)
        {
            highscoretext.text = "New Highscore!";
            PlayerPrefs.SetInt(highScoreKey2, GameController.score);
            PlayerPrefs.SetInt(highScoreKey3, highScore2);
            PlayerPrefs.SetInt(highScoreKey4, highScore3);
            PlayerPrefs.SetInt(highScoreKey5, highScore4);
            PlayerPrefs.Save();
        }

        else if (GameController.score > highScore3)
        {
            highscoretext.text = "New Highscore!";
            PlayerPrefs.SetInt(highScoreKey3, GameController.score);
            PlayerPrefs.SetInt(highScoreKey4, highScore3);
            PlayerPrefs.SetInt(highScoreKey5, highScore4);
            PlayerPrefs.Save();
        }

        else if (GameController.score > highScore4)
        {
            highscoretext.text = "New Highscore!";
            PlayerPrefs.SetInt(highScoreKey4, GameController.score);
            PlayerPrefs.SetInt(highScoreKey5, highScore4);
            PlayerPrefs.Save();
        }

        else if (GameController.score > highScore5)
        {
            highscoretext.text = "New Highscore!";
            PlayerPrefs.SetInt(highScoreKey5, GameController.score);
            PlayerPrefs.Save();
        }
    }
}
