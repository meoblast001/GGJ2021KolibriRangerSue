using UnityEngine.AI;

public static class NavMeshExtensions
{
    public static bool HasReachedDestination(this NavMeshAgent agent)
    {
        return !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance;
    }
}
