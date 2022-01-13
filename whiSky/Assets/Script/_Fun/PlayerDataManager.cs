using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataManager : MonoBehaviour
{
    private string _playerName;

    private string[] _charaName;
    private string[] _specType = { };
    private bool[,] _specActivate;
    private string[] _statType = { "POW", "REA", "HEA", "DUR", "WIL", "KNO" };
    private bool[,] _statValue;
}
