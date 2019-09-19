using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Motion.Effect.RNMotionEffect
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMotionEffectModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMotionEffectModule"/>.
        /// </summary>
        internal RNMotionEffectModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMotionEffect";
            }
        }
    }
}
