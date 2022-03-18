using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

using System.Linq;

public class SetDestination : MonoBehaviour
{
    public GameObject Target;
    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject ChoiceEvaluate;
    public bool Sw1 = false;
    public bool Sw2 = false;

    [HideInInspector]
    public NavMeshAgent Agent;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
    }

    public void choice()
    {
        if (Target != null)
            Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target.transform.position);
        { return; }
    }

    public void choice1()
    {
        if (Target != null)
            Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target1.transform.position);
        { return; }
    }

    public void choice2()
    {
        if (Target != null)
            Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target2.transform.position);
        { return; }
    }

    public void choice3()
    {
        if (Target != null)
            Agent = this.GetComponent<NavMeshAgent>();
        Agent.SetDestination(Target3.transform.position);
        { return; }
    }

    public void OnTriggerEnter(Collider stop)
    {
        if (stop.tag == "Stop")
        {
            Agent.speed = 0;
            GameObject.Find("Canvas1").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Canvas1").GetComponent<CanvasGroup>().interactable = false;
            GameObject.Find("Canvas2").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Canvas2").GetComponent<CanvasGroup>().interactable = true;
        }
        if (stop.tag == "Stop1")
        {
            Agent.speed = 0;
            GameObject.Find("Canvas2").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Canvas2").GetComponent<CanvasGroup>().interactable = false;
            GameObject.Find("Canvas3").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Canvas3").GetComponent<CanvasGroup>().interactable = true;
        }
    }

    public void OnTriggerExit(Collider stop)
    {
        //Speedup();
    }

    public void Speedup()
    {
        Agent.speed = 20;
    }
}