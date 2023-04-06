using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Encapsulation
    private float m_Speed = 0.5f;
    public float speed
    {
        get { return m_Speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Speed can't be negative.");
            }
            else
            {
                m_Speed = value;
            }
        }
    }

    // Abstraction
    public virtual void Move()
    {
        transform.Rotate(Vector3.back);
    }

    public void checkSpeed()
    {
        Debug.Log($"Current Speed: {m_Speed}");
    }

    private void Update()
    {
    }
}
