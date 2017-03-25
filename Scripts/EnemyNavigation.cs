
using UnityEngine;
using System.Collections;

public class EnemyNavigation : MonoBehaviour 
{
	private NavMeshAgent navMeshAgent;
	private GameObject Player;
	
	// get reference to our player and out nav mesh agent
	void Start () 
	{
		navMeshAgent = GetComponent<NavMeshAgent>();
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// every frame update our enemry target position to be the current Player position
	void Update () 
	{
		Vector3 playerPosition = Player.transform.position;
		navMeshAgent.SetDestination(playerPosition);	
	}

	void OnTriggerEnter(Collider hit){
		if (hit.CompareTag ("Player")) {

			Application.LoadLevel (1);
		}
	}
	
}
