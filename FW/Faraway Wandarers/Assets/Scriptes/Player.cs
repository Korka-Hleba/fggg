using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5f;
    private float force = 7f;
    private Rigidbody2D rb;
     
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * force * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed * force * Time.deltaTime;
        }

    }
}
