using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowersFactori : MonoBehaviour
{
    public GameObject tower;
    public void CreateTower(TowerVariants towerVariants, Transform parent)
    {  
        tower = Instantiate(Resources.Load<GameObject>($"Towers/{towerVariants}"), parent);
        tower.transform.position = parent.position + new Vector3(0, 0.5f, 0);
    }
    public EnemyWalkController CreateEnemy(EnumyVariants enumyVariants, Transform parent, Transform[] positions)
    {
        GameObject gameObject = Instantiate(Resources.Load<GameObject>($"Enumy/{enumyVariants}"), parent);
        gameObject.transform.position = parent.position + new Vector3(0, 0, 0);
        gameObject.GetComponent<EnemyWalkController>().GetPoints(positions);
        EnemyWalkController enemyWalkController = gameObject.GetComponent<EnemyWalkController>();

        return enemyWalkController;
    }
}
