using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    [SerializeField]
    private GameObject panel;
    void Start()
    {
        content.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (content.activeInHierarchy)
            {
                content.SetActive(false);
                panel.SetActive(true);
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                content.SetActive(true);
                panel.SetActive(false);
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
            }
            
        }
    }
    public void MusicVolum(float value)
    {
        AllGameData.MusicVolume = value;
    }
    public void EnabledMusic(bool value)
    {
        AllGameData.EnabledMusic = value;
    }
    public void EnableedTaskPanel(bool value)
    {
        AllGameData.EnabledTaskPanel = value;
    }

    public void Resume()
    {
        content.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
