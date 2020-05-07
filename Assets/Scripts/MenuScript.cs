using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void TopicsScreen ()
    {
        SceneManager.LoadScene(1);
    }

    public void StartAR ()
    {
        SceneManager.LoadScene(2);
    }
}
