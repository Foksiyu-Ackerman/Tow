using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySWave : MonoBehaviour
{
    [SerializeField] private Transform[] _movePositionss;
    private TowersFactori _towersFactoris = new TowersFactori();
    private int a = 0;
    private void Start()
    {
        StartCoroutine(SpawnEnemys());
    }

    private IEnumerator SpawnEnemys()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(10f + i);
            StartCoroutine(StartWaves(i));
        }
    }
    private IEnumerator StartWaves(int level)
    {
        for (int i = 0; i < 12; i++)
        {
            if (level == 0)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BAD, transform, _movePositionss);
                enemyWalkController.HpEnemy = 30;
            }
            if (level == 1)
            {
                yield return new WaitForSeconds(2f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BIG, transform, _movePositionss);
                enemyWalkController.HpEnemy = 50;
            }

            if (level == 2)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BIG, transform, _movePositionss);
                enemyWalkController.HpEnemy = 70;
            }

            if (level == 3)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BAD, transform, _movePositionss);
                enemyWalkController.HpEnemy = 40;
            }

            if (level == 4)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BIG, transform, _movePositionss);
                enemyWalkController.HpEnemy = 100;
            }

            if (level == 5)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BAD, transform, _movePositionss);
                enemyWalkController.HpEnemy = 50;
            }

            if (level == 6)
            {
                yield return new WaitForSeconds(1f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BIG, transform, _movePositionss);
                enemyWalkController.HpEnemy = 100;
            }
            if (level == 7)
            {
                yield return new WaitForSeconds(2f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BAD, transform, _movePositionss);
                enemyWalkController.HpEnemy = 500;
            }

            if (level == 8)
            {
                yield return new WaitForSeconds(6f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BIG, transform, _movePositionss);
                enemyWalkController.HpEnemy = 10000;
                a += 1;

            }
            if (level == 9 && a >= 1)
            {
                SceneManager.LoadScene(6);
            }
        }
    }
}