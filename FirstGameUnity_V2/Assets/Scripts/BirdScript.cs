using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public static bool gamePaused = false;

    public Rigidbody2D birdRigidBody;

    public float flapStrength;

    public LogicManagerScript logic;

    public bool birdAlive = true;

    public float deadZone = -18;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerController();

        if (transform.position.y < deadZone || transform.position.y > (deadZone + 36))
        {
            Debug.Log("Bird out of reach");

            logic.GameOver();
            birdAlive = false;
        }

    }

    private void PlayerController()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive != false && gamePaused != true)
        {
            birdRigidBody.velocity = Vector2.up * flapStrength;
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();

        }
    }

    private void PauseGame()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
            gamePaused = true;
        }
        else
        {
            gamePaused = false;
            Time.timeScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdAlive = false;
    }
}
