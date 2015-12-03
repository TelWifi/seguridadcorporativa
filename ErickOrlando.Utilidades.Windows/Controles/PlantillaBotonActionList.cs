using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace ErickOrlando.Utilidades.Windows.Controles
{

    public class PlantillaBotonActionList : DesignerActionList
    {
        // Fields
        private DesignerActionUIService designerActionUISvc;
        private PlantillaBoton m_PlantillaBoton;

        // Methods
        public PlantillaBotonActionList(IComponent component) : base(component)
        {
            this.designerActionUISvc = null;
            this.m_PlantillaBoton = (PlantillaBoton)component;
            this.designerActionUISvc = (DesignerActionUIService)base.GetService(typeof(DesignerActionUIService));
        }

        private PropertyDescriptor GetPropertyByName(string propName)
        {
            PropertyDescriptor descriptor = TypeDescriptor.GetProperties(this.m_PlantillaBoton)[propName];
            if (descriptor == null)
            {
                throw new ArgumentException("Propiedad no encontrada!", propName);
            }
            return descriptor;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();
            items.Add(new DesignerActionHeaderItem("Apariencia"));
            items.Add(new DesignerActionHeaderItem("Comportamiento"));
            items.Add(new DesignerActionPropertyItem("CajaTexto", "Caja de Texto", "Comportamiento", "Permite establecer una Caja de Texto al boton"));
            items.Add(new DesignerActionPropertyItem("CajaTextoConBoton", "Caja de Texto con Boton", "Comportamiento", "Permite establecer un ButtonEdit al boton"));
            items.Add(new DesignerActionPropertyItem("Imagen", "Imagen del boton", "Apariencia", "Permite colocar una imagen estandar al boton"));
            return items;
        }

        // Properties
        public TextEdit CajaTexto
        {
            get
            {
                return this.m_PlantillaBoton.CajaTexto;
            }
            set
            {
                this.GetPropertyByName("CajaTexto").SetValue(this.m_PlantillaBoton, value);
            }
        }

        public ButtonEdit CajaTextoConBoton
        {
            get
            {
                return this.m_PlantillaBoton.CajaTextoConBoton;
            }
            set
            {
                this.GetPropertyByName("CajaTextoConBoton").SetValue(this.m_PlantillaBoton, value);
            }
        }

        public PlantillaBoton.TipoBoton Imagen
        {
            get
            {
                return this.m_PlantillaBoton.Imagen;
            }
            set
            {
                this.GetPropertyByName("Imagen").SetValue(this.m_PlantillaBoton, value);
            }
        }
    }


}
