using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab : MonoBehaviour {

    //set in editorf
    public GameObject[] menuObjects;
    public GameObject[] otherTabs;

    public void closeAll()
    {
        foreach (GameObject go in menuObjects)
        {
            go.SetActive(false);
        }
    }

    public void onClick ()
    {
        foreach (GameObject go in otherTabs)
        {
            go.GetComponent<Tab>().closeAll();
        }
        foreach (GameObject go in menuObjects)
        {
            go.SetActive(!go.activeSelf);
        }
    }
}
