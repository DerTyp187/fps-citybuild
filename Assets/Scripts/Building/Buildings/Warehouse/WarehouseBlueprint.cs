using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseBlueprint : BuildingBlueprint
{
    private MeshRenderer[] childrenMeshRenderer;

    public override void Init()
    {
        //Haus cube �m Obj -> hier wird es benutzt zum material �ndern
        childrenMeshRenderer = gameObject.GetComponentsInChildren<MeshRenderer>();
    }

    public override void WhileColliding()
    {
        //Wenn es collidet soll der HouseCube IM Object ver�ndert werden!
        //Das ist bei jedem Building anders
        foreach(MeshRenderer r in childrenMeshRenderer)
        {
            r.material = collisionMat;
        }
        
    }

    public override void WhileNotColliding()
    {
        //Das selbe wie bei "WhileColliding"
        foreach (MeshRenderer r in childrenMeshRenderer)
        {
            r.material = blueprintMat;
        }
    }
}
