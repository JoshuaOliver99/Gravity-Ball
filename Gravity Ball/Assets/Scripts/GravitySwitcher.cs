using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwitcher : MonoBehaviour
{
    // ----- Vairables -----
    // Gravity Directions
    bool upEnabled;
    bool downEnabled;
    bool leftEnabled;
    bool rightEnabled;

    int activeDirection = 2; // (0-4 - Neutral, Up, Down, Left, Right)

    float switchTimer;
    float switchCooldown;
    bool switchAllowed;

    // ----- References -----
    GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        if (ball == null)
            ball = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Vector2 gravity = Physics2D.gravity;
            Physics2D.gravity = -Physics2D.gravity;
            Debug.Log("Switching gravity");
        }
    }


    public void SetGravity_Up()
    {
        Physics2D.gravity = new Vector2(0, 9.8f);
    }

    public void SetGravity_Down()
    {
        Physics2D.gravity = new Vector2(0, -9.8f);
    }

    public void SetGravity_Left()
    {
        Physics2D.gravity = new Vector2(-9.8f, 0);
    }

    public void SetGravity_Right()
    {
        Physics2D.gravity = new Vector2(9.8f, 0);
    }


}


// Source: https://docs.unity3d.com/ScriptReference/Physics2D-gravity.html