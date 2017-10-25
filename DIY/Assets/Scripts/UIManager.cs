using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public void CreateSearchItems()
    {
        var getDataScript= (GetData)GetComponent("GetData");
        var data = getDataScript._items;

        // Position for button placement
        float xPos = 8;
        float yPos = 140;

        // Quick and dirty way to wait for data to load
        StartCoroutine(waitForTime());

        if (GameObject.Find("ResultItemButton(Clone)") == null)
        {
            // Create items based on process name from MockItem
            foreach (var item in data)
            {
                GameObject resultItemButton = (GameObject)Instantiate(Resources.Load("ResultItemButton"));
                resultItemButton.GetComponentInChildren<Text>().text = item.ProcessName;
                resultItemButton.transform.SetParent(GameObject.Find("SearchPanel").transform, false);
                resultItemButton.transform.localPosition = new Vector3(xPos, yPos, 0);

                yPos -= 35;
            }
        }
        
    }

    IEnumerator waitForTime()
    {
        yield return new WaitForSeconds(1);
    }
}
