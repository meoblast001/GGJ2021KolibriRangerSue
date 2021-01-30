using UnityEngine;

public class CatHideSocksState : ICatState
{
    private readonly CatController _catController;
    private readonly System.Random _random = new System.Random();

    public CatHideSocksState(CatController catController)
    {
        _catController = catController;
    }

    public void Start()
    {
        var target = GetRandomTarget();
        _catController.NavMeshAgent.SetDestination(target);
    }

    public void End()
    {
        _catController.NavMeshAgent.ResetPath();
    }

    public void Update()
    {
        var target = GetRandomTarget();
        _catController.NavMeshAgent.SetDestination(target);
    }

    private Vector3 GetRandomTarget()
    {
        var targets = _catController.Config.CatTargets.Targets;
        var idx = _random.Next() % targets.Count;
        return targets[idx];
    }
}