using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void exit()
    {
        Application.Quit();
    }
    public void ChangeS()
    {
        SceneManager.LoadScene(sceneName);
    }
}
