using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Art
{
    public class ArtMakerGCode : ArtMaker
    {
        // public float position_x = 150f;
        // public float position_y = 130f;
        
        
        public GameObject root { get; set; }

        void LateUpdate()
        {
            if (Input.GetKey(KeyCode.R))
                rebuild = true;
            if (rebuild)
            {
                Rebuild();
                rebuild = false;
            }
        }

        public override void Rebuild()
        {
            if (root != null)
            {
                Destroy(root);
            }

            root = new GameObject();
            root.name = "ArtMaker_Root";
            // root.transform.position = new Vector3(position_x, position_y, 0);
            MakeArt();
        }

        public void AddToRoot(Transform t)
        {
            t.transform.parent = root.transform;
            // t.transform.position = new Vector3(position_x, position_y, 0);
        }

        public virtual void MakeArt()
        {
            /*
             * Make your art in this function
             * Make every new object the child of root.transform
             * "yourGameObject.transform.SetParent(root.transform);"
             * or
             * "yourGameObject.transform.parent = root.transform;
             */
        }
    }
}

