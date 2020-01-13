using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary")
        {
            return;
        }
        if(GameObject.FindWithTag("Food") == gameObject && other.tag == "Player")
        {
            GameController.score+=1;
            Destroy(gameObject);
        }
        else if (GameObject.FindWithTag("Bomb") == gameObject && other.tag == "Player")
        {
            GameController.lives -= 1;
            Destroy(gameObject);

            if (GameController.lives == 0)
            {
                Destroy(GameObject.FindWithTag("Player"));
                SceneManager.LoadScene(3);
            }
        }
        else if (other.tag == "Food" || other.tag == "Bomb")
        {
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
