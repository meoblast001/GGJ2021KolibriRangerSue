using System;
using Cats.States;
using UnityEngine;
using UnityEngine.AI;

public class CatController : MonoBehaviour
{
    private const float MaxSample = 5f;

    private CatState _stateIdentifier;
    private ICatState _state;
    private NavMeshAgent _navMeshAgent;
    private SockInventory _inventory;
    private bool _catchingCatnip;

    public CatConfig Config { set; get; }

    public NavMeshAgent NavMeshAgent => _navMeshAgent;
    public SockInventory Inventory => _inventory;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _inventory = new SockInventory();
    }

    private void Start()
    {
        NavMeshAgent.WarpApproximate(Config.SpawnPosition, MaxSample);

        SwitchState(CatState.HideSocks);
    }

    private void FixedUpdate()
    {
        _state?.Update();
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
            case CatState.CatchesCatnip:
                _state = new CatCatchesCatnipState(this, SwitchState, _stateIdentifier);
                break;
        }

        _stateIdentifier = stateIdentifier;

        Debug.Log($"Cat is entering state {stateIdentifier}");
        _state.Start();
    }

    public void CatchCatnip()
    {
        if (_stateIdentifier == CatState.CatchesCatnip)
        {
            return;
        }

        SwitchState(CatState.CatchesCatnip);
    }

    public void ReleaseCatnip()
    {
        if (_stateIdentifier != CatState.CatchesCatnip)
        {
            return;
        }

        _state.End();
    }
}
