using System;
using UniRx;
using UnityEngine;

public class CatHideSocksState : ICatState
{
    private const float MaxSampleDistance = 5f;

    private readonly CatController _catController;
    private readonly Action<CatState> _switchState;
    private readonly System.Random _random = new System.Random();

    private IDisposable _switchStateSubscription;

    public CatHideSocksState(CatController catController, Action<CatState> switchState)
    {
        _catController = catController;
        _switchState = switchState;
    }

    public void Start()
    {
        var socksCollection = SocksCollection.Singleton;
        _switchStateSubscription = socksCollection.WashingMachineHasSocks
            .Where(washingMachineHasSocks => washingMachineHasSocks && _catController.Inventory.SockCount == 0)
            .Subscribe(_ => _switchState(CatState.GetLaundrySocks));

        var target = GetRandomTarget();
        _catController.NavMeshAgent.SetApproximateDestination(target, MaxSampleDistance);
    }

    public void End()
    {
        _switchStateSubscription.Dispose();
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

    public void OnTriggerEnter(Collider other)
    {
    }

    private Vector3 GetRandomTarget()
    {
        var targets = _catController.Config.CatTargets.Targets;
        var idx = _random.Next() % targets.Count;
        return targets[idx];
    }
}
