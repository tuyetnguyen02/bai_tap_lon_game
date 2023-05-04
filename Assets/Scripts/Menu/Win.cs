using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] public GameObject win;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;  // dừng mọi hoạt động
        ReLoadScene();
    }
    public void ReLoadScene()
    {
        win.SetActive(true);
    }
}
