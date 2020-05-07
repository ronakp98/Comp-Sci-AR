using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenHandler : MonoBehaviour {

	public Button nextButton;
	public Button prevButton;
	public Animator animator;
	public GameObject textObject;

	private int clicks = 0;

	// Use this for initialization
	void Start()
	{
		Button nextBtn = nextButton.GetComponent<Button>();
		Button prevBtn = prevButton.GetComponent<Button>();

		textObject.SetActive(false);

		nextBtn.onClick.AddListener(NextTaskOnClick);
		prevBtn.onClick.AddListener(PrevTaskOnClick);
	}

	// Function for clicking
	void NextTaskOnClick()
	{

		clicks++;

		switch (clicks)
		{
			case 6:
				animator.Play("greenCar Appear");
				textObject.SetActive(true);
				break;
			case 9:
				animator.Play("greenCar Forward");
				break;
			case 10:
				animator.Play("greenCar Reverse");
				break;
			case 11:
				animator.Play("greenCar Right");
				break;
			case 12:
				animator.Play("greenCar Left");
				break;
			default:
				break;
		}

	}

	// Function for clicking
	void PrevTaskOnClick()
	{

		clicks--;

		switch (clicks)
		{
			case -1:
				clicks = 0;
				break;
			case 6:
				animator.Play("greenCar Appear");
				textObject.SetActive(true);
				break;
			case 9:
				animator.Play("greenCar Forward");
				break;
			case 10:
				animator.Play("greenCar Reverse");
				break;
			case 11:
				animator.Play("greenCar Right");
				break;
			case 12:
				animator.Play("greenCar Left");
				break;
			default:
				break;
		}

	}
}