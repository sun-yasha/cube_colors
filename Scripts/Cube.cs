using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed, tilt;
    private Vector3 target = new Vector3(0, 1.5f, -4f);

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 0.5f) target.y = 0.5f;
        else if (transform.position == target && target.y == 0.5f) target.y = 1.5f;

        transform.Rotate(Vector3.up * Time.deltaTime * tilt);
    }
}
