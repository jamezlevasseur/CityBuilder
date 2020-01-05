using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour {

    public void showSettingsMenu()
    {
        VarHub.canvas.transform.Find("SettingsPanel").gameObject.SetActive(true);
    }
}
