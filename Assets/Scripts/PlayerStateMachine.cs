using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine 
{
    protected Player Player;
    protected AttackSO AttackSO;

    public PlayerStateMachine(Player player)
    {
        Player = player;
        AttackSO = player.AttackSO;
    }

}
