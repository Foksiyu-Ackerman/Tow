using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnTower : MonoBehaviour
{
    private Button _button;
    [SerializeField] private PositionControler _positionControler;
    [SerializeField] private TowerVariants _towerVariants;
    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SelectTowerVariant);
    }

    public void SelectTowerVariant()
    {
        _positionControler.OnTowerVariantSelect.Invoke(_towerVariants);
    }
    
}
