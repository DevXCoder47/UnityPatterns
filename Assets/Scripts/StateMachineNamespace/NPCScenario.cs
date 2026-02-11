namespace StateMachineNamespace
{
    public static class NPCScenario
    {
        private static int _step;

        public static IState Next(NPC npc, StateMachine stateMachine)
        {
            _step++;

            switch (_step)
            {
                case 1:
                    return new MoveState(npc, stateMachine, 5f);
                case 2:
                    return new TurnState(npc, stateMachine, 90f);
                case 3:
                    return new MoveState(npc, stateMachine, 5f);
                case 4:
                    return new TurnState(npc, stateMachine, -90f);
                case 5:
                    return new MoveState(npc, stateMachine, 5f);
                default:
                    return new IdleState();
            }
        }
    }
}
