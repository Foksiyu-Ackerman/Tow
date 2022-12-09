using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionControler : MonoBehaviour
{
    [SerializeField] private List<SelectPosition> _selectPosition = new List<SelectPosition>();
    [SerializeField] private List<SpawnTower> _spawnTower = new List<SpawnTower>();
    public Action<TowerVariants> OnTowerVariantSelect;
    private TowerVariants _tower;
    public TowerVariants Tower { get => _tower; set => _tower = value; }

    private void OnEnable()
    {
        OnTowerVariantSelect += SetTowerVariant;
    }
    private void OnDisable()
    {
        OnTowerVariantSelect -= SetTowerVariant;
    }
    public void SetTowerVariant(TowerVariants tower)
    {
        
        _tower = tower;
    }

}
