using UnityEngine;

namespace StateMachineNamespace
{
    public class MoveState : IState
    {
        private readonly NPC _npc;
        private readonly StateMachine _stateMachine;
        private readonly float _distance;

        private Vector3 _startPosition;

        public MoveState(NPC npc, StateMachine stateMachine, float distance)
        {
            _npc = npc;
            _stateMachine = stateMachine;
            _distance = distance;
        }

        public void Enter()
        {
            _startPosition = _npc.transform.position;
        }

        public void Update()
        {
            _npc.MoveForward();

            if (Vector3.Distance(_startPosition, _npc.transform.position) >= _distance)
            {
                _stateMachine.SetState(NPCScenario.Next(_npc, _stateMachine));
            }
        }

        public void Exit() { }
    }
}
