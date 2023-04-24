using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTest : MonoBehaviour
{
    [SerializeField]
    private GameObject secondTest;
    void Start()
    {
        secondTest.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (AllGameData.IsMeatPeaked)
        {
            secondTest.SetActive(true);
        }
    }
}
