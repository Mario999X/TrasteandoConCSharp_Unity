using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public static bool gamePaused;

    public Rigidbody2D birdRigidBody;

    public float flapStrength;

    public LogicManagerScript logic;

    public bool birdAlive = true;

    public float deadZone = -18;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerController();

        if (birdAlive)
        {
            BirdOutOfReach();
        }
    }

    // Controles y acciones del jugador.
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

    // Pausamos el juego con el uso de Time. Esta funcion se tiene en cuenta en LogicManagerScript.
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

    // Si el pajaro choca con una tuberia, se pierde la partida.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdAlive)
        {
            logic.GameOver();
            birdAlive = false;
        }
    }

    // Si el pajaro sale de la camara a demasiada distancia, se pierde la partida.
    private void BirdOutOfReach()
    {
        if (transform.position.y < deadZone || transform.position.y > (deadZone + 36))
        {
            Debug.Log("Bird out of reach");

            logic.GameOver();
            birdAlive = false;
        }
    }
}
