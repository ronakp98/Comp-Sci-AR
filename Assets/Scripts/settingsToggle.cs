using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lean.Touch;



public class settingsToggle : MonoBehaviour {

	public GameObject arContent;
	public Button scaleButton;
	public Button rotateButton;

	// Use this for initialization
	void Start () { 

		Button scaleBtn = scaleButton.GetComponent<Button>();
		Button rotateBtn = rotateButton.GetComponent<Button>();

		scaleBtn.onClick.AddListener(toggleScale);
		rotateBtn.onClick.AddListener(toggleRotate);

		scaleButton.image.color = new Color32(255, 220, 220, 255);
		rotateButton.image.color = new Color32(255, 220, 220, 255);
	}

    void toggleScale()
    {
		arContent.GetComponent<LeanPinchScale>().enabled = !arContent.GetComponent<LeanPinchScale>().enabled;

        if (arContent.GetComponent<LeanPinchScale>().enabled)
        {
			scaleButton.image.color = new Color32(220, 250, 220, 255);
        }
        else
        {
			scaleButton.image.color = new Color32(255, 220, 220, 255);
		}
	}


    void toggleRotate()
    {
		arContent.GetComponent<LeanTwistRotateAxis>().enabled = !arContent.GetComponent<LeanTwistRotateAxis>().enabled;

		if (arContent.GetComponent<LeanTwistRotateAxis>().enabled)
		{
			rotateButton.image.color = new Color32(220, 250, 220, 255);
		}
		else
		{
			rotateButton.image.color = new Color32(255, 220, 220, 255);
		}
	}
}
