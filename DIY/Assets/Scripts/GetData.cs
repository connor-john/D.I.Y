using Assets.Scripts;
using System.Collections;
using UnityEngine;

public class GetData : MonoBehaviour {
    public string _DatabaseConnection = @"http://diy-320.azurewebsites.net/tables/MockDB?zumo-api-version=2.0.0";
    MockItem[] _items;
    bool _fetchedItems = false;

    // Use this for initialization
    void Start () {
        WWW www = new WWW(_DatabaseConnection);
        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            var dataString = JsonHelper.AppendWrapper(www.text);
            _items = JsonHelper.FromJson<MockItem>(dataString);

            ItemsFetched();
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

    // Update is called once per frame
    void Update () {

	}

    // Method called after items have been fetched
    // Can use _fetchedItems boolean to check in other methods such as update
    public void ItemsFetched()
    {
        _fetchedItems = true;
        Debug.Log("First process item name is: " + _items[0].ProcessName);
    }

    public ArrayList GetProducts()
    {
        var productsList = new ArrayList();
        foreach (var p in _items)
        {
            productsList.Add(p);
        }
        return productsList;
    }

    // Should just be able to copy paste this method and change the method name and property name
    // to get an arraylist of the property that you want. 
    public ArrayList GetComponentNames()
    {
        var compNames = new ArrayList();
        foreach(var p in _items)
        {
            compNames.Add(p.ComponentName);
        }
        return compNames;
    }
}
