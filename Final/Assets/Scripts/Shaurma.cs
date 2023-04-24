using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaurma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character")
        {
            this.gameObject.SetActive(false);
            AllGameData.IsShaurmaReady = true;
            
        }
    }
}
