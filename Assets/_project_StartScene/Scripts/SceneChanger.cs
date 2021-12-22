using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static TMPro.TMP_Dropdown;

public class SceneChanger : MonoBehaviour
{
    public List<string> sceneNames;
    public TMP_Dropdown tMP_Dropdown;

    private void Start()
    {
        AddScenes();
    }

    public void AddScenes()
    {
        tMP_Dropdown.ClearOptions();

        List<OptionData> options = new List<OptionData>();

        foreach (var entry in sceneNames)
        {
            options.Add(new OptionData(entry));
        }

        tMP_Dropdown.AddOptions(options);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(tMP_Dropdown.options[tMP_Dropdown.value].text.ToString());
    }
}
