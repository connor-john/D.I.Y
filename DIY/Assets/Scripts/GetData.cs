using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding.Serialization.JsonFx;


public class GetData : MonoBehaviour {
    public string DatabaseConnection;

	// Use this for initialization
	void Start () {
        string jsonResponse = Request.GET(DatabaseConnection);
        MockItem[] products = JsonReader.Deserialize<MockItem[]>(jsonResponse);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
