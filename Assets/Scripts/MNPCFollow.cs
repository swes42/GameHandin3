using UnityEngine;
using UnityEngine.AI;

public class MNPCFollow : MonoBehaviour
{

    //Transform that NPC has to follow
    public Transform transformToFollow;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Follow player
        agent.destination = transformToFollow.position;
    }
}
