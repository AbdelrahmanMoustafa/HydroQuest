using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class GarbageCollector : MonoBehaviour
{
    [SerializeField] AudioSource coilied;
    [SerializeField] AudioSource back;
    [SerializeField] AudioSource seasound;
    //static private Sprite Tip1;
    //static private Sprite Tip2;
    //static private Sprite Tip3;
    //static private Sprite Tip4;
    //static private Sprite Tip5;
    //static private Sprite Tip6;

    [SerializeField] private Sprite[] TipsArray;

    //Sprite[] Tips = { Tip1, Tip2, Tip3, Tip4, Tip5, Tip6 };
    [SerializeField] public int index = 0;
    private void Start()
    {
        
    //Sprite Tip1 = Resources.Load<Sprite>("Tip1");
    //Sprite Tip2 = Resources.Load<Sprite>("Tip2");
    //Sprite Tip3 = Resources.Load<Sprite>("Tip3");
    //Sprite Tip4 = Resources.Load<Sprite>("Tip4");
    //Sprite Tip5 = Resources.Load<Sprite>("Tip5");
    //Sprite Tip6 = Resources.Load<Sprite>("Tip6");
    //Sprite[] Tips = { Tip1, Tip2, Tip3, Tip4, Tip5,Tip6 };
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //sounds
        seasound.Play();
        if (collision.gameObject.CompareTag("Garbage"))
        {
            coilied.Play();
            int newx = Random.Range(-31, 35);
            collision.gameObject.transform.position = new Vector2(newx, collision.gameObject.transform.position.y + 170);

        }
        if (collision.gameObject.CompareTag("Scroll"))
        {
            coilied.Play();
            int newx = Random.Range(-31, 35);
            collision.gameObject.transform.position = new Vector2(newx, collision.gameObject.transform.position.y + 200);
            index = Random.Range(0, TipsArray.Length);
            GameObject Canvas = GameObject.FindGameObjectWithTag("Canva");
            Image image = Canvas.GetComponent<Image>();
            image.enabled = true;
            image.sprite = TipsArray[index];
            Time.timeScale = 0f;
            
        }

    }

}