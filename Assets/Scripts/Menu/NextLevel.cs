using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nameLevel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Time.timeScale = 0;  // dừng mọi hoạt động
        ReLoadScene();
    }
    public void ReLoadScene()
    {
        /*SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);*/
        /*SceneManager.LoadScene(nameLevel, LoadSceneMode.Additive);*/
        SceneManager.LoadScene(nameLevel);
    }
}
