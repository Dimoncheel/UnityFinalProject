using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    void Start()
    {
        content.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (AllGameData.IsDie)
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            content.SetActive(true);
        }
    }
}
