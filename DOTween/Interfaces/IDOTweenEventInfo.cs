public interface IDOTweenEventInfo
{
    public bool Kill { get; set; }
    public int Loops { get; set; }
    public bool DoesLoop() { return Loops > 0 || Loops == -1; }
}
