using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portail : MonoBehaviour
{
    public GameObject TpOut;
    public GameObject player;
    public AudioSource TpSound;
    public AudioSource MapSong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello");
        player.transform.position = TpOut.transform.position;
        TpSound.Play();
        MapSong.Play();
        
    }
}
