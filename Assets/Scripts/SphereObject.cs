using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SphereObject : Shape // Inheritance
{
    private float speedMultiplier = 2.0f;

    private void Start()
    {
        Speed += speedMultiplier;
        Debug.Log($"{Speed}");
        Speed -= speedMultiplier;
        Speed -= speedMultiplier;
        Debug.Log($"{Speed}");
    }

    public override void Move()
    {
        // Polymorphism
        transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    void Update()
    {
        Move(); // Abstraction
    }
}
