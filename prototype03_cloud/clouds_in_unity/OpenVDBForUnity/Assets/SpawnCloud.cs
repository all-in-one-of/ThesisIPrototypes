using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCloud : MonoBehaviour
{

    public float initialDelay = 1.0f;
    public float rate = 3.0f;
    public Vector3 spawnLocation = new Vector3(-38, 0, 0);
    public GameObject[] clouds;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnNewCloud", initialDelay, rate);
    }

    void SpawnNewCloud()
    {
        Vector3 newLocation = new Vector3(spawnLocation.x, Random.Range(-10, 10), Random.Range(-2, 2));
        GameObject cloud = clouds[Random.Range(0, clouds.Length)];
        GameObject obj = Instantiate(cloud, newLocation, Quaternion.identity);
        MoveCloud mc = obj.GetComponent<MoveCloud>();
        mc.speed = Random.Range(1.0f, 5.0f);
        mc.rotationSpeed = Random.Range(1.0f, 3.0f);
    }
}
