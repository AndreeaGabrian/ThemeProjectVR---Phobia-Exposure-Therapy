using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool clicked;
    public Transform Player;
    private AudioSource source;
    void Start()
    {
        clicked = false;
        source = GetComponent<AudioSource>();
    }
    
    void OnMouseOver()
    {
        {
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                if (dist < 20)
                {
                    if (clicked == false)
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            if (gameObject.name != "Bird2")
                            {
                                gameObject.transform.localScale += new Vector3(2,2,2);
                            }
                            else
                            {
                                gameObject.transform.localScale += new Vector3(0.1f,0.1f,0.1f);
                                gameObject.transform.position += new Vector3(1,0,0);
                            }
                            clicked = true;
                            source.Play();

                        }
                    }
                        

                }
            }

        }

    }
}
