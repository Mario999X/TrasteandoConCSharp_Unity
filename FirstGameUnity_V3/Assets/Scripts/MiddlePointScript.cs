using UnityEngine;

public class MiddlePointScript : MonoBehaviour
{

    public LogicManagerScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }


    // Unity es un motor 3D, siempre hay capas, así que para verificar que sea el usuario (pajaro), el que
    // haya pasado a traves de la zona invisible, se tiene en cuenta su capa.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
        }

    }
}
