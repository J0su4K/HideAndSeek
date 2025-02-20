using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovementAIComponent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 location = Vector3.zero;
    [SerializeField] NavMeshAgent agent = null;
    [SerializeField] bool useDebug = true;

    [field:SerializeField] public bool CanMove { get;  set; } = true;
    public bool IsAtLocation => Vector3.Distance(gameObject.transform.position, location) <= 1.5f;

    void Start()
    {
        // agent.path.
        Init();
    }

    void Update()
    {
        //MoveTo();
    }

    public void MoveTo()
    {
        if (!agent && !CanMove) return;

        if(!CanMove)
        {
            Debug.Log("Vous ne pouvez plus bouger");
            agent.SetDestination(gameObject.transform.position);
            return;
        }
        //agent.Move(location);
        if(IsAtLocation)
        {
            Debug.Log("Bravo vous etes a destination");
            CanMove = false;
            return;
        }
        agent.SetDestination(location);
    }


    void Init()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnDrawGizmos()
    {
        if(!useDebug) return;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(gameObject.transform.position, location);
        Gizmos.color = Color.white;
    }
}
