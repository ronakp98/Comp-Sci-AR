using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yellowHandler : MonoBehaviour
{

	public Button nextButton;
	public Button prevButton;
	public Animator animator;
	public GameObject textObject;

	private int clicks = 0;

	// Use this for initialization
	void Start ()
    {
		Button nextBtn = nextButton.GetComponent<Button>();
		Button prevBtn = prevButton.GetComponent<Button>();

		textObject.SetActive(false);

		nextBtn.onClick.AddListener(NextTaskOnClick);
		prevBtn.onClick.AddListener(PrevTaskOnClick);
	}
	
	// Function for clicking next button
	void NextTaskOnClick () {

		clicks++;

        switch (clicks)
        {
			case 5:
				animator.Play("yellowCar Appear");
				textObject.SetActive(true);
				break;
			case 9:
				animator.Play("yellowForward");
				break;
			case 10:
				animator.Play("yellowCar Reverse");
				break;
			case 11:
				animator.Play("yellowCar right");
				break;
			case 12:
				animator.Play("yellowCar left");
				break;
			default:
				break;
        }
		
	}

    //Function for clicking back button
	void PrevTaskOnClick()
	{

		clicks--;

		switch (clicks)
		{
			case -1:
				clicks = 0;
				break;
			case 5:
				animator.Play("yellowCar Appear");
				textObject.SetActive(true);
				break;
			case 9:
				animator.Play("yellowForward");
				break;
			case 10:
				animator.Play("yellowCar Reverse");
				break;
			case 11:
				animator.Play("yellowCar right");
				break;
			case 12:
				animator.Play("yellowCar left");
				break;
			default:
				break;
		}

	}
}
