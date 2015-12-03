using System.ComponentModel.Design;
using System.Security.Permissions;
using System.Windows.Forms.Design;

namespace ErickOrlando.Utilidades.Windows.Controles
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public class PlantillaBotonControlDesigner: ControlDesigner
    {
        // Fields
        private DesignerActionListCollection lists;

        // Properties
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (this.lists == null)
                {
                    this.lists = new DesignerActionListCollection();
                    this.lists.Add(new PlantillaBotonActionList(base.Component));
                }
                return this.lists;
            }
        }

    }
}
