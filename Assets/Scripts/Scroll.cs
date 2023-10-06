using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    Rigidbody2D rb2;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector3(0, -15,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2.transform.position.y < -72.1)
        {
            int newx = Random.Range(-31, 35);
            int newy = Random.Range(-9, -26);
            rb2.transform.position = new Vector2(newx, rb2.transform.position.y + 200);
        }
    }
}
