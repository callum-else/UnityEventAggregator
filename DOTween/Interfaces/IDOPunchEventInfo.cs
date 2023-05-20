using UnityEngine;

public interface IDOPunchEventInfo : IDOTweenEventInfo
{
    public Vector3 Punch { get; set; }
    public float Duration { get; set; }
    public int Vibrato { get; set; }
}

