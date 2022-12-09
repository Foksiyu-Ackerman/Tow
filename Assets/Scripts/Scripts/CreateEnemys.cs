using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateEnemys : MonoBehaviour
{
    [SerializeField] private Transform[] _movePositions;
    private TowersFactori _towersFactori = new TowersFactori();
    
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(10f + i);
            StartCoroutine(StartWave(i));
        }
    }
    private IEnumerator StartWave(int level)
    {
        for(int i = 0; i < 10;i++)
        {
            if(level == 0)
            {
                yield return new WaitForSeconds(5f);
                EnemyWalkController enemyWalkController = _towersFactori.CreateEnemy(EnumyVariants.BAD, transform, _movePositions);
                enemyWalkController.HpEnemy = 30;
            }
            if (level == 1)
            {
                yield return new WaitForSeconds(3f);
                EnemyWalkController enemyWalkController = _towersFactori.CreateEnemy(EnumyVariants.BIG, transform, _movePositions);
                enemyWalkController.HpEnemy = 50;
            }
            if (level == 2)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactori.CreateEnemy(EnumyVariants.BIG, transform, _movePositions);
                enemyWalkController.HpEnemy = 70;
            }
            if (level == 3)
            {
                yield return new WaitForSeconds(0.1f);
                EnemyWalkController enemyWalkController = _towersFactori.CreateEnemy(EnumyVariants.BIG, transform, _movePositions);
                enemyWalkController.HpEnemy = 100;
            }
            if(level == 6)
            {
                SceneManager.LoadScene(6);
            }
        }
    }
}
