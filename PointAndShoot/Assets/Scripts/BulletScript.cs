using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    // Aqui se comprueba el impacto de la bala, puede detectarse el tipo de enemigo por ejemplo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Mob")
        {
            Debug.Log("Enemy Hit");
        }
        else if (collision.gameObject.name == "Ally")
        {
            Debug.Log("Ally Hit");
        }

        Destroy(gameObject);
    }


    // Comprobamos si se salio de la camara principal para destruir la bala
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
