using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public string URL = "https://github.com/darragh2/Game-alpha";

    public void GoToLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("level2");
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene("level3");
    }

    public void LoadURL()
    {
        Application.OpenURL(URL);
    }

}
