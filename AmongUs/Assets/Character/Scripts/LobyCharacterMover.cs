using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class LobyCharacterMover : CharacterMover
{
    [SyncVar(hook = nameof(SetOwnerNetId_Hook))]
    public uint ownerNetId;
    public void SetOwnerNetId_Hook(uint _, uint newOwerId)
    {
        var players = FindObjectsOfType<AmongUsRoomPlayer>();
        foreach(var player in players)
        {
            if(newOwerId == player.netId)
            {
                player.lobbyPlayerCharacter = this;
                break;
            }
        }
    }
    public void CompleteSpawn()
    {
        if (hasAuthority)
        {
            IsMoveable = true;
        }
    }
}
