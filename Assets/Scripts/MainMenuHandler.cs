using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour {

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        print("Button Clicked!");
        
        //int num = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        
    }
}
