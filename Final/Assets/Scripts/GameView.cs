using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    [SerializeField]
    private GameObject content;

    private TMPro.TextMeshProUGUI meat;
    private TMPro.TextMeshProUGUI souce;
    private TMPro.TextMeshProUGUI lavash;

    // Start is called before the first frame update
    void Start()
    {
        meat=GameObject.Find("MeatText").GetComponent<TMPro.TextMeshProUGUI>();
        souce=GameObject.Find("SouceText").GetComponent<TMPro.TextMeshProUGUI>();
        lavash=GameObject.Find("LavashText").GetComponent<TMPro.TextMeshProUGUI>();
        content.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (AllGameData.EnabledTaskPanel)
        {
            if(content.activeInHierarchy)
            {
                if (AllGameData.IsMeatPeaked)
                {
                    meat.SetText("1");
                }
                if (AllGameData.IsSoucePeaked)
                {
                    souce.SetText("1");
                }
                if (AllGameData.IsLavashPeacked)
                {
                    lavash.SetText("1");
                }
            }
            if (AllGameData.IsDie || AllGameData.IsShaurmaReady)
            {
                content.SetActive(false);
            }
        }
       
      
    }
    public void HidePanel(bool value)
    {
        content.SetActive(value);
    }
}
