using UnityEngine;

public class UpgreatS :  MonoBehaviour
{
    public void Upgrete(string tag)
    {
        if (GameDataStorage.Coins >= 110)
        {
            GameDataStorage.Coins -= 110;
        }
        foreach (GameObject tower in GameObject.FindGameObjectsWithTag(tag))
        {
            tower.GetComponent<TowerView>().chetotam /= 2;
        }
    }
    public void UpgreteFreez(string tag)
    {
        if (GameDataStorage.Coins >= 100)
        {
            GameDataStorage.Coins -= 100;
        }
        foreach (GameObject tower in GameObject.FindGameObjectsWithTag(tag))
        {
            tower.GetComponent<TowerVieFreez>().chetotam /= 2;
        }
    }
} 