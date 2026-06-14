public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus)
        : base(name, description, points)
{
    _targetAmount = targetAmount;
    _bonus = bonus;
    _amountCompleted = 0;
}
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonus, int amountCompleted)
        : base(name, description, points)
{
    _targetAmount = targetAmount;
    _bonus = bonus;
    _amountCompleted = amountCompleted;
}
    public override void RecordEvent()
{
    if (_amountCompleted < _targetAmount)
{
    _amountCompleted++;
}
}
    public override int GetBonus()
{
    if (_amountCompleted == _targetAmount)
{
    return _bonus;
}

    return 0;
}
    public override string GetDetailsString()
{
    string status = _amountCompleted >= _targetAmount ? "[X]" : "[ ]";

    return $"{status} {_name} (Completed {_amountCompleted}/{_targetAmount} times)";
}
    public override string GetStringRepresentation()
{
    return $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetAmount}|{_bonus}|{_amountCompleted}";
}
}