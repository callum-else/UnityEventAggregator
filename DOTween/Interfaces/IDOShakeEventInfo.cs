using UnityEngine;

public interface IDOShakeEventInfo : IDOTweenEventInfo
{
    public Vector3 Strength { get; set; }
    public float Duration { get; set; }
    public int Vibrato { get; set; }
}