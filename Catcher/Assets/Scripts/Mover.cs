using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody rigidBody;
    public float ObjectSpeed;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = transform.up * (-ObjectSpeed); // -ObjectSpeed poniewaz obiekt porusza sie w kierunku ujemnym osi Y; innymi slowy spada
    }
}
