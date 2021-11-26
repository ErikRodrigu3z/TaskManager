using System.Windows.Forms;
using TaskManager.Forms.Modals;

namespace TaskManager.Helpers
{
    public static class MessageHelper
    {
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, 
            MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            //Muestra un cuadro de mensaje con texto, título, botones e íconos especificados

            DialogResult result; //Obtiene o establece el resultado del cuadro de diálogo del formulario.

            // Instanciar al formulario MessageForm utilizando USING para desechar el formulario correctamente cuando haya terminado su propósito.  
            using (var msgForm = new MessageModal(text, caption, buttons, icon, defaultButton))//Establecer otros valores predeterminados
            {
                result = msgForm.ShowDialog(); //Mostrar como formulario modal 
            }

            return result;//Retornar Dialog Result  
        }
    }
}
