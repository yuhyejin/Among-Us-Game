using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AmongUsRoomManager : NetworkRoomManager
{
    public int minPlayerCount;
    public int imposterCount;

    public override void OnRoomServerConnect(NetworkConnection conn)    // 서버에서 새로 접속한 클라이언트를 감지했을때의 함수(roomplayer에 생성되기 전)
    {
        base.OnRoomServerConnect(conn);

        
    }
}
