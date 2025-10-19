using UnityEngine;

namespace Game.FlexActive
{
    /// <summary>
    /// Abstract base class that defines the active state control mechanism.
    /// </summary>
    /// <remarks>
    /// Provides a unified interface for enabling or disabling a specific target. This abstraction
    /// allows for the implementation of different activation mechanisms depending on the derived class.
    /// </remarks>
    public abstract class ActiveStateController : MonoBehaviour
    {
        public abstract void SetActive(bool active);
    }
}