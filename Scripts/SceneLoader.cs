using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public void LoadGameScene()
    {
        int currIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currIndex);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
