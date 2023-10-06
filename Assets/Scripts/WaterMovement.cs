using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]AudioSource sea;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (-3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        sea.Play();
        if (rb.transform.position.x < -79)
        {
            rb.transform.position = new Vector2(133.5f,transform.position.y);
        }
    }
}
