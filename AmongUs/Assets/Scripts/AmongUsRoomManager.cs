using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AmongUsRoomManager : NetworkRoomManager
{
    public override void OnRoomServerConnect(NetworkConnection conn)    // 서버에서 새로 접속한 클라이언트를 감지했을때의 함수
    {
        base.OnRoomServerConnect(conn);

        Vector3 spawnPos = FindObjectOfType<SpawnPositions>().GetSpawnPosition();

        var player = Instantiate(spawnPrefabs[0], spawnPos, Quaternion.identity);
        NetworkServer.Spawn(player, conn);
    }
}
