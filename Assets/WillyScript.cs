using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        flapStrength = 12;
        myRigidbody.gravityScale = 3;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }

}
