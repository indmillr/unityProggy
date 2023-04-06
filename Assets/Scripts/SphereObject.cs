using System.Collections;
using System.Collections.Generic;
<<<<<<< Updated upstream
using System.Diagnostics;
using UnityEngine;

public class SphereObject : Shape // Inheritance
=======
using UnityEngine;

// Inheritance
public class SphereObject : Shape
>>>>>>> Stashed changes
{
    private float speedMultiplier = 2.0f;

    private void Start()
    {
<<<<<<< Updated upstream
        Speed += speedMultiplier;
        Debug.Log($"{Speed}");
        Speed -= speedMultiplier;
        Speed -= speedMultiplier;
        Debug.Log($"{Speed}");
=======
        speed += speedMultiplier;
        Debug.Log($"{speed}");
        speed -= speedMultiplier;
        speed -= speedMultiplier;
        Debug.Log($"{speed}");
>>>>>>> Stashed changes
    }

    public override void Move()
    {
        // Polymorphism
        transform.Rotate(Vector3.right * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

<<<<<<< Updated upstream
    void Update()
    {
        Move(); // Abstraction
=======
    private void Update()
    {
        Move();
>>>>>>> Stashed changes
    }
}
