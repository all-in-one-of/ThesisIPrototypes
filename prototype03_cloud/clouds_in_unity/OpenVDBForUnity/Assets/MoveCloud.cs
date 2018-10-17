using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float speed = 3.0f;
    public float rotationSpeed = 4.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Time.deltaTime * speed, 0, 0));
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
    }
}
