using UnityEngine;
using UnityEngine.AI;

public class CatController : MonoBehaviour
{
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
        transform.position = Config.SpawnPosition;

        //SwitchState(CatState.HideSocks);
    }

    private void Update()
    {
        //_state.Update();
    }

    private void SwitchState(CatState stateIdentifier)
    {
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
