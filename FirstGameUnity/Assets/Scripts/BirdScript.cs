using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidBody;

    public float flapStrength;

    public LogicManagerScript logic;

    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive != false)
        {
            birdRigidBody.velocity = Vector2.up * flapStrength;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdAlive = false;
    }
}
