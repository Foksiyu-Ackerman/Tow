using System;
using System.Collections;
using System.Collections.Generic;

public static class GameDataStorage
{
    private static int _hp = 3;
    private static int _coins = 100;
    private static Action<int> _onCoinsChange;

    public static int Hp { get => _hp; set => _hp = value; }
    public static int Coins { get { return _coins; } set { _coins = value; _onCoinsChange.Invoke(_coins); } }
    public static Action<int> OnCoinsChange { get => _onCoinsChange; set => _onCoinsChange = value; }
}
