using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascenseur : MonoBehaviour
{
    public Transform posStart;
    private float speed = 2f;
    public bool direction;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = posStart.position;
        direction = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction)
            this.transform.Translate(0, 0, -speed * Time.deltaTime);
        else
            this.transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        direction = !direction; // On change la direction à chaque collision
    }
}
