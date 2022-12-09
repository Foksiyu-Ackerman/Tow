using UnityEngine;
using TMPro;

public class CoinsTextView : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;

    private void OnEnable()
    {
        GameDataStorage.OnCoinsChange += ChangeText;
    }
    private void OnDisable()
    {
        GameDataStorage.OnCoinsChange -= ChangeText;
    }
    private void ChangeText(int coins)
    {
        _coinsText.text = "Coins: " + coins ;
    }
}
