using UnityEngine;

namespace Game.FlexActive
{
    /// <summary>
    /// Abstract generic class for managing the active state of a specific Unity Behaviour.
    /// </summary>
    /// <typeparam name="TBehaviour">The type of Behaviour to be controlled.</typeparam>
    /// <remarks>
    /// This class serves as an extension of the ActiveStateController, allowing control over the enabled
    /// state of a specific Behaviour component on a GameObject. It retrieves the required Behaviour
    /// component if not explicitly assigned and toggles its active state based on the provided input.
    /// </remarks>
    public abstract class BehaviourActiveStateController<TBehaviour> : ActiveStateController
        where TBehaviour : Behaviour
    {
        [SerializeField] protected TBehaviour _behaviour;

        protected virtual void OnValidate()
        {
            _behaviour ??= GetComponent<TBehaviour>();
        }

        public override void SetActive(bool active)
        {
            _behaviour.enabled = active;
        }
    }
}