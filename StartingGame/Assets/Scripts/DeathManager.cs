using UnityEngine;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    public int deaths;
    public Text deathText;

    void Awake()
    {
        deaths = PlayerPrefs.GetInt("Counter");
        deathText.text = "Deaths: " + deaths.ToString();
    }

    public void IncreaseDeaths()
    {
        PlayerPrefs.SetInt("Counter", deaths + 1);
    }

}
