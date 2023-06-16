using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask playerLayer, groundLayer;
    public Vector3 specialPoint;
    bool isPointset;
    public float pointRange;
    public float visionRange;
    public bool inVisionRange;

    public float attackTime;
    bool attacked;
    public GameObject bullet;
    public float attackRange;
    public bool inAttackRange;
    public GameObject shootPoint;


    private void Attack() 
    {
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if (!attacked)
        {
            Rigidbody bulletInstance = Instantiate(bullet, shootPoint.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            bulletInstance.AddForce(transform.forward * 50f+transform.up *-2.5f, ForceMode.Impulse);
            
            attacked = true;
            Invoke(nameof(Reset),attackTime);
        }
    }

    private void Reset()
    {
        attacked = false;
    }




   


    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        inVisionRange = Physics.CheckSphere(transform.position, visionRange, playerLayer);
        inAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);
        
        
        if (inVisionRange && inAttackRange)
        {
            Attack();

        }
    }
}
