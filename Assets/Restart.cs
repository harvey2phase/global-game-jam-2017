using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public Button btn;

    void Start()
    {
        Debug.Log(btn.name);
        btn.gameObject.SetActive(true);
        btn.onClick.AddListener(() => Debug.Log("test"));
    }

    public void RestartLevel()
    {
        Debug.Log("test");
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
