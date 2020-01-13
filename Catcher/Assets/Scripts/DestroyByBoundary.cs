using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if(GameObject.FindWithTag("Food") == other.gameObject)
        {
            Destroy(other.gameObject);
            GameController.lives -= 1;
        }

        if(GameController.lives == 0)
        {
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene(3);
        }

        Destroy(other.gameObject);
    }
}
