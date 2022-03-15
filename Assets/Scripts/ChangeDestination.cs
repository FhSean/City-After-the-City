using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class ChangeDestination : MonoBehaviour
    
{
    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;

    [HideInInspector]
    public NavMeshAgent Agent;
    // Start is called before the first frame update
    void Start()
    {
        //if (Target != null) { return; }

        //Agent = this.GetComponent<NavMeshAgent>();
        //Agent.SetDestination(Target.transform.position);

    }

    // Update is called once per frame
    public void choice()
    {
        if (Target != null) 
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target.transform.position);
        { return; }

    }
    public void choice1()
    {
        if (Target1 != null) 
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target1.transform.position);
        { return; }
    }
    public void choice2()
    {
        if (Target2 = null) 
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target2.transform.position);
        { return; }

    }
    public void choice3()
    {
        if (Target3 = null) 
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target3.transform.position);
        { return; }

    }
}
