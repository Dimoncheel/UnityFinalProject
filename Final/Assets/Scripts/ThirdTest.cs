using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTest : MonoBehaviour
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
        if (AllGameData.IsSoucePeaked)
        {
            content.SetActive(true);
        }
    }
  
}
