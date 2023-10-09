namespace RPG
{
    public enum CombatAction
    {
        Unknown,
        BasicAttack,
        Skill,
        UseItem,
        Wait,
        RunAway
    }
    public enum CombatResult
    {
        PlayerVictory,
        EnemyVictory,
        Draw
    }
}
