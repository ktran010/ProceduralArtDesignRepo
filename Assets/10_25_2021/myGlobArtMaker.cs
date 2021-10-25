// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class myGlobArtMaker : ArtMakerTemplate
// {
//     public myGlobManager GlobManager;

//     public override void MakeArt()
//     {
//         base.MakeArt();
//         GlobManager manager = Instantiate(globManager).GetComponent<GlobManager>();
//         manager.Rebuild();
//         AddToRoot(manager.transform);
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Art;

public class myGlobArtMaker : ArtMakerTemplate
{
    public myGlobManager globManager;

    public override void MakeArt()
    {
        base.MakeArt();
        GameObject manager = Instantiate(globManager);
        manager.Rebuild();

        //these two lines are identical
        manager.transform.parent = root.transform;
        AddToRoot(manager.transform);
    }
}