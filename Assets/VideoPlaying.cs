using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoPlaying : MonoBehaviour
{
    RawImage image;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
        image = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Time.timeScale = 1.0f;
            image.enabled = false;
        }
    }
}
