using System;
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

        public static void ShowError(Exception exception)
        {
            string error = "";
            if (exception.InnerException != null)
            {
                error = exception.Message;
            }
            else
            {
                error = exception.InnerException.Message;
            }

            using (var msgForm = new MessageModal(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1))//Establecer otros valores predeterminados
            {
                msgForm.ShowDialog(); //Mostrar como formulario modal 
            }
        }

        public static void ShowSuccess(string message = "") 
        {
            using (var msgForm = new MessageModal(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1))//Establecer otros valores predeterminados
            {
                msgForm.ShowDialog(); //Mostrar como formulario modal 
            }
        }

    }
}
