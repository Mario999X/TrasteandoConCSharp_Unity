using UnityEngine;

public class PipeScript : MonoBehaviour
{

    public float moveSpeed = 5;

    public float deadZone = -45;


    // Update is called once per frame
    // Damos una direccion a la que se desplaza de forma constante, se tiene en cuenta su posicion en la x, y es eliminado.
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipeee Deleted");
            Destroy(gameObject);
        }
    }
}
