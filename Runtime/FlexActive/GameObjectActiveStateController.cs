namespace Game.FlexActive
{
    /// <summary>
    /// A concrete implementation of <see cref="ActiveStateController"/> for controlling
    /// the active state of a GameObject in Unity.
    /// </summary>
    /// <remarks>
    /// This class overrides the <see cref="ActiveStateController.SetActive(bool)"/> method to
    /// enable or disable the associated GameObject's active state.
    /// </remarks>
    public class GameObjectActiveStateController : ActiveStateController
    {
        public override void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }
    }
}