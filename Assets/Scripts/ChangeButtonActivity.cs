using UnityEngine;

public class ChangeButtonActivity : MonoBehaviour
{
    [SerializeField] private GameObject _buttonOnUpgrade;
    [SerializeField] private GameObject _buttonOffUpgrade;
    [SerializeField] private GameObject _buttonFirstOnImprovement;
    [SerializeField] private GameObject _buttonFirstOffImprovement;
    [SerializeField] private GameObject _buttonSecondOnImprovement;
    [SerializeField] private GameObject _buttonSecondOffImprovement;

    public void ChangeButtonMaxLevel()
    {
        _buttonOnUpgrade.SetActive(false);
        _buttonOffUpgrade.SetActive(true);
    }

    public void ChangeButtonFirstEmprovement()
    {
        _buttonFirstOnImprovement.SetActive(false);
        _buttonFirstOffImprovement.SetActive(true);
    }

    public void ChangeButtonSecondEmprovement()
    {
        _buttonSecondOnImprovement.SetActive(false);
        _buttonSecondOffImprovement.SetActive(true);
    }

}