using System.Collections;
using System.Collections.Generic;

using UnityEditor.Rendering;
using UnityEngine;

public class ShotGunSystem : MonoBehaviour
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
        if (Input.GetButtonDown("Fire1"))
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
        Vector3 shootDirection2 = shootDirection + new Vector3(-2.0f,0f,0f);
        Vector3 shootDirection3 = shootDirection + new Vector3(+2.0f, 0f, 0f);
        Vector3 shootDirection4 = shootDirection + new Vector3(0f, +2f, 0f);
        Vector3 shootDirection5 = shootDirection + new Vector3(0f, -2f, 0f);
        Vector3 shootDirection6 = shootDirection + new Vector3(-2.0f, -2.0f, 0f);
        Vector3 shootDirection7 = shootDirection + new Vector3(+2.0f, +2.0f, 0f);
        Vector3 shootDirection8 = shootDirection + new Vector3(-2.0f, +2f, 0f);
        Vector3 shootDirection9 = shootDirection + new Vector3(+2.0f, -2f, 0f);

        GameObject realBullet1 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet2 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet3 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet4 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet5 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet6 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet7 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet8 = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        GameObject realBullet9 = Instantiate(bullet, shootPoint.position, Quaternion.identity);

        realBullet1.transform.forward = shootDirection.normalized;
        realBullet1.GetComponent<Rigidbody>().AddForce(shootDirection.normalized * speed, ForceMode.Impulse);
        realBullet2.transform.forward = shootDirection2.normalized;
        realBullet2.GetComponent<Rigidbody>().AddForce(shootDirection2.normalized * speed, ForceMode.Impulse);
        realBullet3.transform.forward = shootDirection3.normalized;
        realBullet3.GetComponent<Rigidbody>().AddForce(shootDirection3.normalized * speed, ForceMode.Impulse);
        realBullet4.transform.forward = shootDirection4.normalized;
        realBullet4.GetComponent<Rigidbody>().AddForce(shootDirection4.normalized * speed, ForceMode.Impulse);
        realBullet5.transform.forward = shootDirection5.normalized;
        realBullet5.GetComponent<Rigidbody>().AddForce(shootDirection5.normalized * speed, ForceMode.Impulse);
        realBullet6.transform.forward = shootDirection6.normalized;
        realBullet6.GetComponent<Rigidbody>().AddForce(shootDirection6.normalized * speed, ForceMode.Impulse);
        realBullet7.transform.forward = shootDirection7.normalized;
        realBullet7.GetComponent<Rigidbody>().AddForce(shootDirection7.normalized * speed, ForceMode.Impulse);
        realBullet8.transform.forward = shootDirection8.normalized;
        realBullet8.GetComponent<Rigidbody>().AddForce(shootDirection8.normalized * speed, ForceMode.Impulse);
        realBullet9.transform.forward = shootDirection9.normalized;
        realBullet9.GetComponent<Rigidbody>().AddForce(shootDirection9.normalized * speed, ForceMode.Impulse);


    }
}
