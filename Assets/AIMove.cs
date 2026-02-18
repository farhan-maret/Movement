using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }
}