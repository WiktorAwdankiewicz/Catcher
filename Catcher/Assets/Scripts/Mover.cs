using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody rigidBody;
    //float ObjectSpeed = 50;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        //rigidBody.velocity = transform.up * (-ObjectSpeed); // -Speed poniewaz obiekt porusza sie w kierunku ujemnym osi Y; innymi slowy spada
    }

    void Update()
    {
        GameController.speed += 0.2f * Time.deltaTime;
        rigidBody.velocity = transform.up * (-GameController.speed); // -Speed poniewaz obiekt porusza sie w kierunku ujemnym osi Y; innymi slowy spada

        //ObjectSpeed += 0.1f;
        //rigidBody.velocity = transform.up * (-ObjectSpeed); // -Speed poniewaz obiekt porusza sie w kierunku ujemnym osi Y; innymi slowy spada

    }
}
