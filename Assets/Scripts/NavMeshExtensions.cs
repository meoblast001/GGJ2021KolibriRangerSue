using UnityEngine;
using UnityEngine.AI;

public static class NavMeshExtensions
{
    public static bool HasReachedDestination(this NavMeshAgent agent)
    {
        return !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance;
    }

    public static bool WarpApproximate(this NavMeshAgent agent, Vector3 destination, float maxDistance)
    {
        if (NavMesh.SamplePosition(destination, out var hit, maxDistance, agent.areaMask))
        {
            agent.Warp(hit.position);
            return true;
        }

        return false;
    }

    public static bool SetApproximateDestination(this NavMeshAgent agent, Vector3 destination, float maxDistance)
    {
        if (NavMesh.SamplePosition(destination, out var hit, maxDistance, agent.areaMask))
        {
            agent.SetDestination(hit.position);
            return true;
        }

        return false;
    }
}
