using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiveDanege : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyWalkController>())
        {
            Destroy(other.gameObject);
            GameDataStorage.Hp -= 1;
            GameDataStorage.Coins += 10;
            if (GameDataStorage.Hp == 0)
            {
                SceneManager.LoadScene(4);
                GameDataStorage.Hp = 3;
                GameDataStorage.Coins = 100;
            }
        }
    }
}
