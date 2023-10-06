using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GarbageScribt : MonoBehaviour
{
    private Rigidbody2D rigidbody2;
    [SerializeField] AudioSource back;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
        rigidbody2.velocity = new Vector3(0, -15, 10);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2.transform.eulerAngles += Vector3.forward * 2;
        back.Play();
        if (rigidbody2.transform.position.y < -72.1) {
            int newx = Random.Range(-31, 35);
            int newy = Random.Range(-9, -26);
            rigidbody2.transform.position=new Vector2(newx, rigidbody2.transform.position.y + 170);
        }
    }

}
