using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BackAndForthAI : MonoBehaviour {

	public NavMeshAgent Agent;
	public Transform Obj1;
	public Transform Obj2;
	private Transform CurrObj;

	void Start () {
		Agent = GetComponent<NavMeshAgent>();
		CurrObj = Obj1;
	}
	
	void Update () {
		Agent.destination = CurrObj.position;
	}
	private void OnTriggerEnter(Collider other)
	{
		if(CurrObj == Obj1)
			CurrObj = Obj2;
		else
			CurrObj = Obj1;
	}
}
