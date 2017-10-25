using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultItemHandler : MonoBehaviour {

    public Button yourButton;

    // Use this for initialization
    void Start () {
        yourButton.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        var parentObject = GameObject.Find("Canvas");
        parentObject.FindObject("SearchPanel").SetActive(false);
        parentObject.FindObject("ItemPanel").SetActive(true);

        parentObject = GameObject.Find("ChairHolder");
        parentObject.FindObject("chair").SetActive(true);
    }
}
