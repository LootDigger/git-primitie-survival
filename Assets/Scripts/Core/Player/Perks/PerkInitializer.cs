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

    public void InstantiateGunslingerPerk()
    {
        Debug.Log("InstantiateGunslingerPerk");

        var component = gameObject.AddComponent<GunslingerPerk>();
        _container.Inject(component);
    }
    
    public void InstantiateGarlicPerk()
    {
        Debug.Log("InstantiateGarlicPerk");

        var component = gameObject.AddComponent<SaintGarlicPerk>();
        _container.Inject(component);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            InstantiateGunslingerPerk();
        }
        
        if (Input.GetKeyDown(KeyCode.F2))
        {
            InstantiateGarlicPerk();
        }
    }
}
