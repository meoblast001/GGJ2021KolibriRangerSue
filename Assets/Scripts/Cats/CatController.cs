using UnityEngine;
using UnityEngine.AI;

public class CatController : MonoBehaviour
{
    private const float MaxSample = 5f;

    private CatState _stateIdentifier;
    private ICatState _state;
    private NavMeshAgent _navMeshAgent;
    private CatInventory _inventory;

    public CatConfig Config { set; get; }

    public NavMeshAgent NavMeshAgent => _navMeshAgent;
    public CatInventory Inventory => _inventory;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _inventory = new CatInventory();
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
        _state.OnTriggerEnter(other);
    }

    private void SwitchState(CatState stateIdentifier)
    {
        if (_state != null)
            _state.End();

        switch (stateIdentifier)
        {
            case CatState.HideSocks:
                _state = new CatHideSocksState(this, SwitchState);
                break;
            case CatState.GetLaundrySocks:
                _state = new CatGetLaundrySocksState(this, SwitchState);
                break;
        }

        _state.Start();
    }

    public void DealWithCatnip()
    {
        Debug.Log("DealWithCatnip");
    }
}
