using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging_UIHandler : PersistentSingleton<Debugging_UIHandler>
{
    [SerializeField] GameObject showHierarchy_GO;
    [SerializeField] GameObject hideHierarchy_GO;
    [SerializeField] GameObject showInspector_GO;
    [SerializeField] GameObject hideInspector_GO;
    [SerializeField] GameObject console_GO;

    public void TurnOnOffDebugButtons()
    {
        if (showHierarchy_GO.activeSelf)
        {
            showHierarchy_GO.SetActive(false);
            hideHierarchy_GO.SetActive(false);
            showInspector_GO.SetActive(false);
            hideInspector_GO.SetActive(false);
            console_GO.SetActive(false);
        }
        else
        {
            showHierarchy_GO.SetActive(true);
            hideHierarchy_GO.SetActive(true);
            showInspector_GO.SetActive(true);
            hideInspector_GO.SetActive(true);
            console_GO.SetActive(true);
        }
    }
}
