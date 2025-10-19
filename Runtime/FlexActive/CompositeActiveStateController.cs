using System.Collections.Generic;

namespace Game.FlexActive
{
    /// <summary>
    /// Manages the activation state of multiple <see cref="ActiveStateController"/> instances as a composite controller.
    /// </summary>
    /// <remarks>
    /// The <c>CompositeActiveStateController</c> allows grouping several individual
    /// <see cref="ActiveStateController"/> instances and controlling their active states collectively.
    /// When the <c>SetActive</c> method is called, it propagates the active state to all
    /// registered controllers contained within the <c>Controllers</c> list.
    /// </remarks>
    public class CompositeActiveStateController : ActiveStateController
    {
        public List<ActiveStateController> Controllers = new();

        public override void SetActive(bool active)
        {
            foreach (ActiveStateController controller in Controllers)
                controller.SetActive(active);
        }
    }
}