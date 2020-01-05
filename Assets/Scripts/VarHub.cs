using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarHub : MonoBehaviour {

    public static GameObject canvas;

	// Use this for initialization
	void Awake () {
        canvas = GameObject.Find("Canvas");
	}

}
