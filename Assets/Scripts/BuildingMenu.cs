using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenu : MonoBehaviour {

    public void showBuildingMenu ()
    {
        VarHub.canvas.transform.Find("BuildingPanel").gameObject.SetActive(true);
    }

    public void placeBuilding()
    {
        GameObject newobj = Instantiate(Resources.Load("Prefabs/Cube") as GameObject);
        VarHub.canvas.transform.Find("BuildingPanel").gameObject.SetActive(false);
    }
}
