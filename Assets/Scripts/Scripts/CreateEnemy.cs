using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _movePositionss;
    private TowersFactori _towersFactoris = new TowersFactori();
    
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
        for(int i = 0; i < 10;i++)
        {
            yield return new WaitForSeconds(3f);
            if (level == 0)
            {
                yield return new WaitForSeconds(3f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BAD, transform, _movePositionss);
                enemyWalkController.HpEnemy = 30;
            }
            yield return new WaitForSeconds(3f);
            if (level == 1)
            {
                yield return new WaitForSeconds(2f);
                EnemyWalkController enemyWalkController = _towersFactoris.CreateEnemy(EnumyVariants.BIG, transform, _movePositionss);
                enemyWalkController.HpEnemy = 50;
            }

            if (level == 2)
            {
                yield return new WaitForSeconds(3f);
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
                SceneManager.LoadScene(6);
            }
        }
    }
}
