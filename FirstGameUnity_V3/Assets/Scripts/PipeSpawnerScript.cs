using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;

    public float spawnRate;

    private float timer = 0;

    public float heightOffSet = 10;

    // Start is called before the first frame updates
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    // Generamos un nuevo Prefab de las tuberias, dandoles un valor aleatorio para variar su posicion Y
    private void SpawnPipe ()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0) , transform.rotation);
    }
}