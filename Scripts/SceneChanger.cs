> SceneChanger.cs 0.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public bool TableEntered = false;
    public bool FromSettings = false;
    public bool FromProfile = false;

    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
    public void TableScene()
    {
        SceneManager.LoadScene("TableScene");
    }
    public void ProfileScene()
    {
        SceneManager.LoadScene("ProfileScene");
    }
    public void SettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void CloseSettings()
    {
        if (TableEntered == true)
        {
            FromSettings = true;
            SceneManager.LoadScene("TableScene");
        }
        else if (TableEntered == false)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }

    public void CloseProfile()
    {
        if (TableEntered == true)
        {
            FromProfile = true;
            SceneManager.LoadScene("TableScene");
        }
        else if (TableEntered == false)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
