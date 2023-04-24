using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControl : MonoBehaviour
{
    [SerializeField]
    private GameObject menuContent;
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject gameView;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.0f;
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AllGameData.EnabledMusic)
        {
            if (AllGameData.IsDie || AllGameData.IsShaurmaReady)
            {
                audioSource.Stop();
            }
        }
        else
        {
            audioSource.Stop();
        }
       
    }

    public void StartGame()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Cursor.visible = false;
        Time.timeScale = 1.0f;
        menuContent.SetActive(false);
        background.SetActive(false);
        gameView.SetActive(true);
        audioSource.Play();
    }
    public void ExitButtonClick()
    {
        if (UnityEditor.EditorUtility.DisplayDialog("Game will be ended", "Are you realy want exit?", "YES", "NO"))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }

    }
}
