using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScenes : MonoBehaviour
{
    public Button button;
    public string nameScene;
    void Start()
    {
        button.onClick.AddListener(taskOnclick);
    }
    public void taskOnclick()
    {
        SceneManager.LoadScene(nameScene);
    }

}
