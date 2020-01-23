using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidBody;
    public float PlayerSpeed;
    public Boundary boundary;
    private float ScreenWidth;
    private Vector2 startPos;

    void Start()
    {
        ScreenWidth = Screen.width;
        rigidBody = GetComponent<Rigidbody>();
    }

    //funkcje wykorzystywane przez przyciski na ekranie do poruszania sie
    public void MoveRight()
    {
        rigidBody.velocity = new Vector2(PlayerSpeed, 0.0f);
    }

    public void MoveLeft()
    {
        rigidBody.velocity = new Vector2(-PlayerSpeed, 0.0f);
    }

    public void StopMoving()
    {
        rigidBody.velocity = new Vector2(0.0f, 0.0f);
    }

    void FixedUpdate()
    {
        //Movement Postaci na PC
        /*float x = Input.GetAxisRaw("Horizontal");
        if (x == 1)
        {
            MoveRight();
        }
        else if (x == -1)
        {
            MoveLeft();
        }
        else
        {
            StopMoving();
        }*/

        //Movement Postaci na Android - bez przyciskow na ekranie
        /*if (Input.touchCount > 0)
        {
            //Vector3 touchPosition = Input.GetTouch(0).position;
            //touchPosition.z = 0.0f;
            //touchPosition = Camera.main.ScreenToWorldPoint(touchPosition);
            Touch touch = Input.GetTouch(0);
            switch(touch.phase)
            {
                case TouchPhase.Stationary:
                    if (touch.position.x > rigidBody.position.x)  //ScreenWidth / 2)
                    {
                        MoveRight();
                    }
                    else if (touch.position.x < rigidBody.position.x)
                    {
                        MoveLeft();
                    }
                    break;

                case TouchPhase.Ended:
                    StopMoving();
                    break;
            }
        }*/

        rigidBody.position = new Vector3
        (
            Mathf.Clamp(rigidBody.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            0.0f
        );
    }
}
