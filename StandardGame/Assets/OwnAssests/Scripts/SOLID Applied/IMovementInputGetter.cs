using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementInputGetter 
{ 
    float Horizontal { get; }
    float Vertical { get; }
    bool Jump { get; }
    bool CounterJump { get; }

}
