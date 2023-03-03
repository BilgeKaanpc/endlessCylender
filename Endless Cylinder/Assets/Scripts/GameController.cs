using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Game Objects
    [SerializeField] GameObject player;

    [SerializeField] List<GameObject> barriers;

    GameObject soundController;
    SoundController sounds;


    private void Awake()
    {
        soundController = GameObject.Find("SoundController");
        sounds = soundController.GetComponent<SoundController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       player.transform.Translate(Vector3.forward * 50 * Time.deltaTime);
    }
    private void FixedUpdate()
    {
    }
}
