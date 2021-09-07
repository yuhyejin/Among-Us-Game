using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobyCharacterMover : CharacterMover
{
    public void CompleteSpawn()
    {
        if (hasAuthority)
        {
            isMoveable = true;
        }
    }
}
