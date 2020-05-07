using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

	public Button nextButton;
	public Button prevButton;
	public Animator animator;
	public Text explnText;
	public GameObject textObject;
	public TextMesh activeText;

	private int clicks = 0;
	private string text;

	void Start()
	{
		Button nextBtn = nextButton.GetComponent<Button>();
		Button prevBtn = prevButton.GetComponent<Button>();

		textObject.SetActive(false);

		nextBtn.onClick.AddListener(NextTaskOnClick);
		prevBtn.onClick.AddListener(PrevTaskOnClick);

		animator = GetComponent<Animator>();

		explnText.text = "Welcome!!\n This application will show you the basic concepts of object-oriented programming through the use of Augmented Reality (AR). The first topic will be on classes and objects.";
		activeText.text = "";
	}

	void NextTaskOnClick()
	{
		clicks++;

		switch (clicks)
		{
			case 1:
				text = "Before pressing the NEXT button please scan your flashcard target\nThe flashcard for the first lesson is \n'Classes and Objects'";
				explnText.text = text;
				break;
			case 2:
				text = "By definition, a class is a blueprint for creating objects.\n It contains both member variables (fields) and member functions (methods)";
				explnText.text = text;
				break;
			case 3:
				animator.Play("cube Appear");
				textObject.SetActive(true);
				text = "Let's imagine that this blueprint car represents a car class. The fields represent different attributes of the car class, which can hold information about the car";
				explnText.text = text;
				break;
			case 4:
				text = "The methods represent different functions that are defined inside the class. These methods can allow the objects created from the class to carry out certain actions";
				explnText.text = text;
				break;
			case 5:
				//yellowCar appears
				text = "Since we now understand what each part of the car class does, let's create an object yellow car from this blueprint car class. This yellowCar object has its fields from the class, which are defined for its attributes, shown above the object";
				explnText.text = text;
				break;
			case 6:
				//greenCar appears
				text = "Now that we have created a yellowCar object, let's create another car object and call it greenCar. This car object has defined its fields to its own attributes shown above the greenCar object";
				explnText.text = text;
				break;
			case 7:
				text = "Now we have created two separate car objects, both were created from the same blueprint car class. Both cars objects have access to the methods listed in the car class.\n Let’s call a few of these methods";
				explnText.text = text;
				break;
			case 8:
				text = "The first method that is defined in the car class is accelerate(). This method allows the car objects to move forward. Let's call this method for both of the cars and observe the results";
				explnText.text = text;
				break;
			case 9:
				//Both cars should accelerate forward
				activeText.text = "accelerate()";
				text = "We observe that both cars moved forward when the accelerate() method was called. Next, we should try calling the reverse() method for both car objects.";
				explnText.text = text;
				break;
			case 10:
				//Both cars should reverse back to their spots
				activeText.text = "reverse()";
				text = "As we just saw, both of the cars reversed back into their original spot.\n Let's try to have both of the cars turn right by calling the turnRight() method.";
				explnText.text = text;
				break;
			case 11:
				//Both cars should turn right
				activeText.text = "turnRight()";
				text = "We have now made both of the cars turn right. Let's call the last method that was defined in the car class to have the cars turn left. This method is called with turnLeft()";
				explnText.text = text;
				break;
			case 12:
				//Both cars should turn left
				activeText.text = "turnLeft()";
				text = "We have now called all the methods defined in the car class. This is the benefit of using classes in programming. It allows the car class to have the foundation to create multiple cars objects";
				explnText.text = text;
				break;
			case 13:
				activeText.text = "";
				text = "We had one car class that declared the fields and methods. We used this blueprint car class as a foundation to create multiple real-life car objects with different attributes, which can access the different methods of the class";
				explnText.text = text;
				break;
			case 14:
				text = "This was a basic implementation of classes and objects. This understanding can be adapted to many other examples as well, such as: \nAnimal Class\nBook Class";
				explnText.text = text;
				break;
			case 15:
				text = "This object-oriented concept could be used throughout your programming career as it is a fundamental computing concept.";
				explnText.text = text;
                //Change next button to next
				nextButton.GetComponentInChildren<Text>().text = "Next";
				break;
			case 16:
				text = "This is the end of the lesson! Hope you learned the concept of this lesson.\n Press Quit to return to the Main Menu or press the button in the top right to discover more examples of a class!";
				explnText.text = text;
				//Change next button to quit
				nextButton.GetComponentInChildren<Text>().text = "Quit";
				break;
			case 17:
				SceneManager.LoadScene(0);
				break;
			default:

				break;
		}

	}

	void PrevTaskOnClick()
	{
		clicks--;

		switch (clicks)
		{
			case -1:
				clicks = 0;
				break;
			case 1:
				text = "Before pressing the NEXT button please scan your flashcard target\nThe flashcard for the first lesson is \n'Classes and Objects'";
				explnText.text = text;
				break;
			case 2:
				text = "By definition, a class is a blueprint for creating objects.\n It contains both member variables (fields) and member functions (methods)";
				explnText.text = text;
				break;
			case 3:
				animator.Play("cube Appear");
				textObject.SetActive(true);
				text = "Let's imagine that this blueprint car represents a car class. The fields represent different attributes of the car class, which can hold information about the car";
				explnText.text = text;
				break;
			case 4:
				text = "The methods represent different functions that are defined inside the class. These methods can allow the objects created from the class to carry out certain actions";
				explnText.text = text;
				break;
			case 5:
				//yellowCar appears
				text = "Since we now understand what each part of the car class does, let's create an object yellow car from this blueprint car class. This yellowCar object has its fields from the class, which are defined for its attributes, shown above the object";
				explnText.text = text;
				break;
			case 6:
				//greenCar appears
				text = "Now that we have created a yellowCar object, let's create another car object and call it greenCar. This car object has defined its fields to its own attributes shown above the greenCar object";
				explnText.text = text;
				break;
			case 7:
				text = "Now we have created two separate car objects, both were created from the same blueprint car class. Both cars objects have access to the methods listed in the car class.\n Let’s call a few of these methods";
				explnText.text = text;
				break;
			case 8:
				text = "The first method that is defined in the car class is accelerate(). This method allows the car objects to move forward. Let's call this method for both of the cars and observe the results";
				explnText.text = text;
				break;
			case 9:
				//Both cars should accelerate forward
				activeText.text = "accelerate()";
				text = "We observe that both cars moved forward when the accelerate() method was called. Next, we should try calling the reverse() method for both car objects.";
				explnText.text = text;
				break;
			case 10:
				//Both cars should reverse back to their spots
				activeText.text = "reverse()";
				text = "As we just saw, both of the cars reversed back into their original spot.\n Let's try to have both of the cars turn right by calling the turnRight() method.";
				explnText.text = text;
				break;
			case 11:
				//Both cars should turn right
				activeText.text = "turnRight()";
				text = "We have now made both of the cars turn right. Let's call the last method that was defined in the car class to have the cars turn left. This method is called with turnLeft()";
				explnText.text = text;
				break;
			case 12:
				//Both cars should turn left
				activeText.text = "turnLeft()";
				text = "We have now called all the methods defined in the car class. This is the benefit of using classes in programming. It allows the car class to have the foundation to create multiple cars objects";
				explnText.text = text;
				break;
			case 13:
				activeText.text = "";
				text = "We had one car class that declared the fields and methods. We used this blueprint car class as a foundation to create multiple real-life car objects with different attributes, which can access the different methods of the class";
				explnText.text = text;
				break;
			case 14:
				text = "This was a basic implementation of classes and objects. This understanding can be adapted to many other examples as well, such as: \nAnimal Class\nBook Class";
				explnText.text = text;
				break;
			case 15:
				text = "This object-oriented concept could be used throughout your programming career as it is a fundamental computing concept.";
				explnText.text = text;
				//Change next button to next
				nextButton.GetComponentInChildren<Text>().text = "Next";
				break;
			case 16:
				text = "This is the end of the lesson! Hope you learned the concept of this lesson.\n Press Quit to return to the Main Menu or press the button in the top right to discover more examples of a class!";
				explnText.text = text;
				//Change next button to quit
				nextButton.GetComponentInChildren<Text>().text = "Quit";
				break;
			case 17:
				SceneManager.LoadScene(0);
				break;
			default:

				break;
		}

	}
}
