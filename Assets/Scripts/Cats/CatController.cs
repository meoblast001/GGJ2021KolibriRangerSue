using UnityEngine;
using UnityEngine.AI;

public class CatController : MonoBehaviour
{
    private const float MaxSample = 5f;

    private CatState _stateIdentifier;
    private ICatState _state;
    private NavMeshAgent _navMeshAgent;

    public CatConfig Config { set; get; }

    public NavMeshAgent NavMeshAgent => _navMeshAgent;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        NavMeshAgent.WarpApproximate(Config.SpawnPosition, MaxSample);

        SwitchState(CatState.HideSocks);
    }

    private void Update()
    {
        _state.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        var washingMachineTrigger = other.GetComponent<WashingMachineTrigger>();
        if (washingMachineTrigger != null)
        {
            
        }
    }

    private void SwitchState(CatState stateIdentifier)
    {
        if (_state != null)
            _state.End();

        switch (stateIdentifier)
        {
            case CatState.HideSocks:
                _state = new CatHideSocksState(this);
                break;
        }

        _state.Start();
    }
}
