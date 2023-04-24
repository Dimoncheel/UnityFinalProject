using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavash : MonoBehaviour
{
    [SerializeField]
    private GameObject shaurma;
    // Start is called before the first frame update
    void Start()
    {
        
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
            AllGameData.IsLavashPeacked = true;
            shaurma.SetActive(true);
        }
    }
}
