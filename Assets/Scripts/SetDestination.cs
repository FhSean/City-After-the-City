using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

public class SetDestination : MonoBehaviour
{
    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    [HideInInspector]
    public NavMeshAgent Agent;
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void GoTarget(GameObject target)
    {
        //guard statement
        if (Target == null) { return; } //if agent is disable just exit method

        Target = target;
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target.transform.position);
    }
    public void GoTarget1(GameObject target)
    {
        //guard statement
        if (Target1 == null) { return; } //if agent is disable just exit method

        Target = target;
        Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target.transform.position);
    }

}
