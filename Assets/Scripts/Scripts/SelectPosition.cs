using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPosition : MonoBehaviour
{
    [SerializeField] private PositionControler _positionControler;
    private TowersFactori _towersFactori = new TowersFactori();
    private bool _empty = true;
    
    public void OnMouseDown()
    {
        Debug.Log(_empty);
        Debug.Log(_positionControler.Tower);
        
            if (_empty == false)
            {
                return;
            }
            if (_positionControler.Tower != TowerVariants.NONE && GameDataStorage.Coins >= 30)
            {
                    _empty = false;
                    _towersFactori.CreateTower(_positionControler.Tower, transform);
                    _positionControler.Tower = TowerVariants.NONE;
                    GameDataStorage.Coins -= 30;
            }
    }
    
}
