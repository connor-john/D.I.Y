using Assets.Scripts;
using System.Collections;
using UnityEngine;
using CI.HttpClient;

public class GetData : MonoBehaviour {
    public string _DatabaseConnection = @"http://diy-320.azurewebsites.net/tables/MockDB?zumo-api-version=2.0.0";
    MockItem[] _items;
    bool _fetchedItems = false;

    // Use this for initialization
    void Start () {
        GetItems();
    }

    // Async call, will complete in the background and set _fetchedItems to true once complete.
    public void GetItems()
    {
        HttpClient client = new HttpClient();
        client.GetByteArray(new System.Uri(_DatabaseConnection), HttpCompletionOption.AllResponseContent, (r) =>
        {
            string dataString = System.Text.Encoding.UTF8.GetString(r.Data);
            dataString = JsonHelper.AppendWrapper(dataString);
            _items = JsonHelper.FromJson<MockItem>(dataString);

            ItemsFetched();
        });
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
