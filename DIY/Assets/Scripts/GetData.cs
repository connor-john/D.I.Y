using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding.Serialization.JsonFx;
using System.Linq;

public class GetData : MonoBehaviour {
    public string DatabaseConnection = @"http://diy-320.azurewebsites.net/tables/MockDB?zumo-api-version=2.0.0";
    MockItem[] products;

    // Use this for initialization
    void Start () {
        string jsonResponse = Request.GET(DatabaseConnection);
        products = JsonReader.Deserialize<MockItem[]>(jsonResponse);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public ArrayList GetProducts()
    {
        var productsList = new ArrayList();
        foreach (var p in products)
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
        foreach(var p in products)
        {
            compNames.Add(p.ComponentName);
        }
        return compNames;
    }
}
