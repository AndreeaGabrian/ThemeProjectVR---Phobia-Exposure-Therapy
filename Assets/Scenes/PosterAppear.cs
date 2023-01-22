using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterAppear : MonoBehaviour
{
    public BlueDoor BlueDoorelem;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        //BlueDoorelem = FindObjectOfType<BlueDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (BlueDoorelem.was_opened == true)
        // {
        //     Debug.Log("a fost!!!!!");
        //     gameObject.SetActive(true);
        // }
    }
}
