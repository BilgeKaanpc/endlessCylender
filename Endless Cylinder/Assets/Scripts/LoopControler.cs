using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopControler : MonoBehaviour
{
    //Game Objects
    [SerializeField] GameObject cylinder;


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
        if(other.gameObject.tag == "Player")
        {
            cylinder.transform.position = new Vector3(0,0,cylinder.transform.position.z + 60);
            Debug.Log("Deðid");
        }
    }
}
