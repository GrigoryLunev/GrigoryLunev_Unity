using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class ClaireMove : MonoBehaviour
{
    private Animator anim;
    private NavMeshAgent agent;
    public GameObject target;
    private float animSpeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       // anim.speed = animSpeed;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
