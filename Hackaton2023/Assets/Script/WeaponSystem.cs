using System.Collections;
using System.Collections.Generic;

using UnityEditor.Rendering;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public Camera playerCamera;
    public Transform shootPoint;
    public GameObject bullet;
    public float speed = 10f;
    public AudioSource fireNoise;
    public GameObject muzzleFlash;
    



    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
            
        }
        
    }

    void shoot()
    {
        fireNoise.Play();
        GameObject muzzleInstance = Instantiate(muzzleFlash, shootPoint.position, Quaternion.identity);
        Destroy(muzzleInstance, 1f);
        
        Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;
        Vector3 target;
        if (Physics.Raycast(ray, out hit))
        {
            target = hit.point; 
        }
        else
        {
            target = ray.GetPoint(75);
        }
        Vector3 shootDirection = target - shootPoint.position;
        GameObject realBullet = Instantiate(bullet, shootPoint.position,Quaternion.identity);
        realBullet.transform.forward = shootDirection.normalized;
        realBullet.GetComponent<Rigidbody>().AddForce(shootDirection.normalized*speed, ForceMode.Impulse);

    }
}
