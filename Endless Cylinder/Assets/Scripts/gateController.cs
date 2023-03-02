using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateController : MonoBehaviour
{
    [SerializeField] Material green;
    [SerializeField] GameObject passEffect;
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
            Debug.Log("geçti0");
            GetComponentInChildren<MeshRenderer>().material = green;
            Instantiate(passEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
