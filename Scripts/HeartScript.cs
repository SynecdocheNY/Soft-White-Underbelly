using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartScript : MonoBehaviour
{
    Image selfImage;

    // Start is called before the first frame update
    void Start()
    {
        selfImage = GetComponent<Image>();
        selfImage.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Fade from black
        if (selfImage.color.a < 1) selfImage.color = new Color(1, 1, 1, selfImage.color.a + 0.002f);
    }
}
