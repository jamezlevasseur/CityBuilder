using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Camera.main);
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 pos = r.GetPoint(5);
        transform.position = pos;
        if (Input.GetMouseButton(0))
        {
            GameObject newBuild = Instantiate(Resources.Load("Prefabs/Building") as GameObject);
            newBuild.transform.position = transform.position;
            Destroy(gameObject);
        }
    }
}
