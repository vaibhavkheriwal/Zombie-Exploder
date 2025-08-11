using UnityEngine;
using UnityEngine.AI;
public class FollowPlayer : MonoBehaviour
{
    private GameObject player;
    private NavMeshAgent agent;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.destination = player.transform.position;
    }
}
