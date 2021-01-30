using UnityEngine;

public class CatHideSocksState : ICatState
{
    private const float MaxSampleDistance = 5f;

    private readonly CatController _catController;
    private readonly System.Random _random = new System.Random();

    public CatHideSocksState(CatController catController)
    {
        _catController = catController;
    }

    public void Start()
    {
        var target = GetRandomTarget();
        _catController.NavMeshAgent.SetApproximateDestination(target, MaxSampleDistance);
    }

    public void End()
    {
        _catController.NavMeshAgent.ResetPath();
    }

    public void Update()
    {
        if (_catController.NavMeshAgent.HasReachedDestination())
        {
            _catController.NavMeshAgent.ResetPath();
            var target = GetRandomTarget();
            _catController.NavMeshAgent.SetApproximateDestination(target, MaxSampleDistance);
        }
    }

    private Vector3 GetRandomTarget()
    {
        var targets = _catController.Config.CatTargets.Targets;
        var idx = _random.Next() % targets.Count;
        return targets[idx];
    }
}
