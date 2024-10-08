using System.Collections;
using System.Collections.Generic;
using Core.Player.Perks;
using UnityEngine;
using Zenject;

public class PerkInitializer : MonoBehaviour
{
    private DiContainer _container;

    [Inject]
    void Init(DiContainer newContainer)
    {
        _container = newContainer;
    }

    public void InstantiateComponent()
    {
        Debug.Log("InstantiateComponent");

        var component = gameObject.AddComponent<GunslingerPerk>();
        _container.Inject(component);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            InstantiateComponent();
        }
    }
}
