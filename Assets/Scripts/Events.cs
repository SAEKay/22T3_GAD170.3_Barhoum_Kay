using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayBarhoum

{



    public class Events : MonoBehaviour
    {
        public delegate void VoidDelegate();

        // This is the EVENT itself.
        public static VoidDelegate OnTeleporterEvent;
        public static VoidDelegate OnColourChangerEvent;
    }
}
