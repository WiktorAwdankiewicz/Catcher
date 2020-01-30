using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class highscorebtn : MonoBehaviour
{
    public void GoToHighscores()
    {
        SceneManager.LoadScene(4);
    }
}
