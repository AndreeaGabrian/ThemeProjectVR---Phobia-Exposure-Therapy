using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
		public Door3_1 Door31;
		public Door3_2 Door32;
		public Door3_3 Door33;
		public Door3_4 Door34;

		public BlueDoor BlueDoor2;
		public GameObject poster1;
		public GameObject poster2;
		private AudioSource source;

		void Start()
		{
			open = false;
			source = GetComponent<AudioSource>();
		}

		void OnMouseOver()
		{
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 15)
					{
						if (open == false)
						{
							if (Input.GetMouseButtonDown(0))
							{
								source.Play();
								StartCoroutine(opening());
								
								
								if (gameObject.name == "Door3_1")
								{
									Door31 = FindObjectOfType<Door3_1>();
									Door31.was_opened = true;
								}
								
								if (gameObject.name == "Door3_2")
								{
									Door32 = FindObjectOfType<Door3_2>();
									Door32.was_opened = true;
								}
								
								if (gameObject.name == "Door3_3")
								{
									Door33 = FindObjectOfType<Door3_3>();
									Door33.was_opened = true;
								}
								
								if (gameObject.name == "Door3_4")
								{
									Door34 = FindObjectOfType<Door3_4>();
									Door34.was_opened = true;
								}
								
								if (gameObject.name == "BlueDoor")
								{
									poster1.SetActive(true);
									poster2.SetActive(true);
								}
							}
						}
						else
						{
							if (open == true)
							{
								if (Input.GetMouseButtonDown(0))
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}