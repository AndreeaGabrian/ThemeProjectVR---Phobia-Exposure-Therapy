using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBlock : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Door3_1 Door31;
    public Door3_2 Door32;
    public Door3_3 Door33;
    public Door3_4 Door34;
    public GameObject bird2;
    public GameObject poster;
    void Start()
    {
        Door31 = FindObjectOfType<Door3_1>();
        Door32 = FindObjectOfType<Door3_2>();
        Door33 = FindObjectOfType<Door3_3>();
        Door34 = FindObjectOfType<Door3_4>();
        bird2.SetActive(false);
        poster.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Door31.was_opened == true && Door32.was_opened == true && Door33.was_opened == true && Door34.was_opened == true)
        {
            gameObject.SetActive(false);
            bird2.SetActive(true);
            poster.SetActive(true);
        }
    }
}
