using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressButton : MonoBehaviour
{
    public GameObject presser;
    public Transform Player;
    private bool isPressed;
    AudioSource sound;
    public GameObject poster1;
    public GameObject poster2;

    // Update is called once per frame
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
        poster1.SetActive(false);
        poster2.SetActive(false);
    }
    
    void Update()
    {
        
    }
    
    void OnMouseOver()
    {
        {
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 15)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        if (isPressed == false)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                sound.Play();
                                gameObject.transform.localScale += new Vector3(0,-0.2f,0);
                                isPressed = true;
                                if (gameObject.name == "B1")
                                {
                                    poster1.SetActive(true);
                                }
                                if (gameObject.name == "B2")
                                {
                                    poster2.SetActive(true);
                                }

                            }
                        }
                        else
                        {
                            isPressed = false;
                            gameObject.transform.localScale += new Vector3(0,0.2f,0);
                        }
                    }
                   

                }
            }

        }

    }
}
