using System;
using UnityEngine;

namespace Cats.States
{
    public class CatCatchesCatnipState: ICatState
    {
        private readonly CatController _catController;
        private readonly Action<CatState> _switchState;
        private readonly CatState _catState;
        private bool _ended;

        public CatCatchesCatnipState(CatController catController, Action<CatState> switchState, CatState catState)
        {
            _catController = catController;
            _switchState = switchState;
            _catState = catState;
        }

        public void Start()
        {
            _catController.NavMeshAgent.ResetPath();
        }

        public void End()
        {
            if (_ended)
            {
                return;
            }
            _ended = true;
            _switchState(_catState);
        }

        public void Update()
        {
        }

        public void OnTriggerEnter(Collider other)
        {
        }
    }
}