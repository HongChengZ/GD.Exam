using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KidEscapeTrigger : MonoBehaviour
{
    private Text txtMy;
    
    // Start is called before the first frame update
    void Start()
    {
        txtMy = GameObject.Find("Canvas (3)/Text").GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            txtMy.text = "  ???";
            txtMy.color = Color.red;
        }
        
        
    }

}
