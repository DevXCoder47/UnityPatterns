using System.Collections.Generic;
using UnityEngine;

namespace StateMachineNamespace
{
    public class NPC : MonoBehaviour
    {
        public float Speed;
        public float TurnSpeed;
        public List<Transform> Targets;

        private StateMachine _stateMachine;

        void Awake()
        {
            _stateMachine = new StateMachine();
        }

        void Start()
        {
            _stateMachine.SetState(NPCScenario.Next(this, _stateMachine));
        }

        void Update()
        {
            _stateMachine.Update();
        }

        public void MoveForward()
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
    }
}
