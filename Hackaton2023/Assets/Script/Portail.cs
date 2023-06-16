using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portail : MonoBehaviour
{
    public GameObject tp_out;
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
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hello");
            player.transform.position = tp_out.transform.position;
            PlayerMovement.Instance.checkPoint = tp_out;
            TpSound.Play();
            MapSong.Play();

        }
        
        
    }
}
