using UnityEngine;

namespace StateMachineNamespace
{
    public class TurnState : IState
    {
        private readonly NPC _npc;
        private readonly StateMachine _stateMachine;
        private readonly float _angle;

        private Quaternion _targetRotation;

        public TurnState(NPC npc, StateMachine stateMachine, float angle)
        {
            _npc = npc;
            _stateMachine = stateMachine;
            _angle = angle;
        }

        public void Enter()
        {
            _targetRotation =
                Quaternion.Euler(0, _angle, 0) * _npc.transform.rotation;
        }

        public void Update()
        {
            _npc.transform.rotation = Quaternion.RotateTowards(
                _npc.transform.rotation,
                _targetRotation,
                _npc.TurnSpeed * Time.deltaTime
            );

            if (Quaternion.Angle(_npc.transform.rotation, _targetRotation) <= 1f)
            {
                GoNext();
            }
        }

        public void Exit() { }

        private void GoNext()
        {
            _stateMachine.SetState(NPCScenario.Next(_npc, _stateMachine));
        }
    }
}
