using FontAwesome.Sharp;
using RJCodeUI_M1.Settings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManager.Forms.Modals
{
    public partial class MessageModal : Form
    {
        #region Campos

        private Button button1;//Botón número 1
        private Button button2;//Botón número 2
        private Button button3;//Botón número 3
        #endregion

        #region Constructor
        public MessageModal(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();

            txtMessage.Text = text;
            lblCaption.Text = caption;

            CreateIcon(icon);//Crear icono de cuadro de mensaje
            CreateButtons(buttons, defaultButton);
        } 
        #endregion

        #region Methods
        private void CreateIcon(MessageBoxIcon icon)
        {//Establecer icono de cuadro de mensaje

            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pbIcon.IconChar = IconChar.TimesCircle;
                    this.pbIcon.IconColor = Color.FromArgb(241, 98, 96);
                    break;
                case MessageBoxIcon.Information: //Información
                    this.pbIcon.IconChar = IconChar.InfoCircle;
                    this.pbIcon.IconColor = Color.FromArgb(20, 161, 228);
                    break;
                case MessageBoxIcon.Question://Pregunta
                    this.pbIcon.IconChar = IconChar.QuestionCircle;
                    this.pbIcon.IconColor = Color.CornflowerBlue;
                    break;
                case MessageBoxIcon.Exclamation://Exclamación
                    this.pbIcon.IconChar = IconChar.ExclamationTriangle;
                    this.pbIcon.IconColor = Color.FromArgb(255, 177, 17);
                    break;
                case MessageBoxIcon.None: //Ninguno
                    this.pbIcon.IconChar = IconChar.CommentDots;
                    this.pbIcon.IconColor = Color.FromArgb(236, 93, 123);
                    break;

            }
        }

        private void CreateButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    button1 = OKButton(143, 13);
                    break;
                case MessageBoxButtons.OKCancel:
                    button1 = OKButton(79, 13);
                    button2 = CancelButton(205, 13);
                    break;
                case MessageBoxButtons.YesNo:
                    button1 = YesButton(79, 13);
                    button2 = NoButton(205, 13);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    button1 = YesButton(20, 13);
                    button2 = NoButton(146, 13);
                    button3 = CancelButton(272, 13);
                    break;
                case MessageBoxButtons.RetryCancel:
                    button1 = RetryButton(79, 13);
                    button2 = CancelButton(205, 13);
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    button1 = AbortButton(20, 13);
                    button2 = RetryButton(146, 13);
                    button3 = IgnoreButton(272, 13);
                    break;
            }
            ActivateButton(defaultButton);//Especificar el botón predeterminado para el cuadro de mensaje.
        }

        private void ActivateButton(MessageBoxDefaultButton defaultButton)
        {//Enfocar el botón predeterminado y el usuario puede presionar directamente la tecla Enter para realizar la acción del botón
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Enfocar botón 1
                    button1.Select();
                    button1.ForeColor = Color.White;
                    button1.Text = "> " + button1.Text;
                    break;
                case MessageBoxDefaultButton.Button2://Enfocar botón 2
                    if (button2 != null)
                    {
                        button2.Select();
                        button2.Text = "> " + button2.Text;
                        button2.ForeColor = Color.White;

                    }
                    else // Si el botón 2 no existe, enfocar botón 1
                    {
                        button1.Select();
                        button1.ForeColor = Color.White;
                        button1.Text = "> " + button1.Text;
                    }
                    break;
                case MessageBoxDefaultButton.Button3://Enfocar botón 3
                    if (button3 != null)
                    {
                        button3.Select();
                        button3.ForeColor = Color.White;
                        button3.Text = "> " + button3.Text;
                    }
                    else //Si el botón 3 no existe, enfocar botón 1
                    {
                        button1.Select();
                        button1.ForeColor = Color.White;
                        button1.Text = "> " + button1.Text;
                    }
                    break;
            }
        } 
        #endregion

        #region Buttons
        //Botones del cuadro de mensaje
        private Button OKButton(int locationX, int locationY)
        {//Crear botón Aceptar

            Button btnOk;
            btnOk = new Button();
            btnOk.Anchor = AnchorStyles.None;
            btnOk.BackColor = RJColors.Confirm;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnOk.ForeColor = Color.WhiteSmoke;
            btnOk.Location = new Point(locationX, locationY);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(110, 35);
            btnOk.Text = "Accept";
            btnOk.UseVisualStyleBackColor = false;

            btnOk.DialogResult = DialogResult.OK;//Establecer DialogResult

            pnlButtons.Controls.Add(btnOk);//Agregar botón

            return btnOk;

        }
        private new Button CancelButton(int locationX, int locationY)
        {//Crear botón Cancelar

            Button btnCancel;
            btnCancel = new Button();
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = RJColors.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(locationX, locationY);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 35);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;

            btnCancel.DialogResult = DialogResult.Cancel;//Establecer DialogResult

            pnlButtons.Controls.Add(btnCancel);//Agregar botón

            return btnCancel;
        }
        private Button YesButton(int locationX, int locationY)
        {//Crear botón Sí.

            Button btnYes;
            btnYes = new Button();
            btnYes.Anchor = AnchorStyles.None;
            btnYes.BackColor = RJColors.Confirm;
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnYes.ForeColor = Color.WhiteSmoke;
            btnYes.Location = new Point(locationX, locationY);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(110, 35);
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;

            btnYes.DialogResult = DialogResult.Yes;//Establecer DialogResult

            pnlButtons.Controls.Add(btnYes);//Agregar botón.

            return btnYes;
        }
        private Button NoButton(int locationX, int locationY)
        {//Crear botón No.

            Button btnNo;
            btnNo = new Button();
            btnNo.Anchor = AnchorStyles.None;
            btnNo.BackColor = RJColors.Delete;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnNo.ForeColor = Color.WhiteSmoke;
            btnNo.Location = new Point(locationX, locationY);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(110, 35);
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;

            btnNo.DialogResult = DialogResult.No;//Establecer DialogResult

            pnlButtons.Controls.Add(btnNo);//Agregar botón

            return btnNo;
        }
        private Button RetryButton(int locationX, int locationY)
        {//Crear botón Reintentar.

            Button btnRetry;
            btnRetry = new Button();
            btnRetry.Anchor = AnchorStyles.None;
            btnRetry.BackColor = Color.DarkGray;
            btnRetry.FlatAppearance.BorderSize = 0;
            btnRetry.FlatStyle = FlatStyle.Flat;
            btnRetry.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnRetry.ForeColor = Color.WhiteSmoke;
            btnRetry.Location = new Point(locationX, locationY);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(110, 35);
            btnRetry.Text = "Retry";
            btnRetry.UseVisualStyleBackColor = false;

            btnRetry.DialogResult = DialogResult.Retry;//Establecer DialogResult

            pnlButtons.Controls.Add(btnRetry);//Agregar botón

            return btnRetry;
        }
        private Button AbortButton(int locationX, int locationY)
        {//Crear botón Abortar
            Button btnAbort;
            btnAbort = new Button();
            btnAbort.Anchor = AnchorStyles.None;
            btnAbort.BackColor = RJColors.Delete;
            btnAbort.FlatAppearance.BorderSize = 0;
            btnAbort.FlatStyle = FlatStyle.Flat;
            btnAbort.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnAbort.ForeColor = Color.WhiteSmoke;
            btnAbort.Location = new Point(locationX, locationY);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(110, 35);
            btnAbort.Text = "Abort";
            btnAbort.UseVisualStyleBackColor = false;

            btnAbort.DialogResult = DialogResult.Abort;//Establecer DialogResult

            pnlButtons.Controls.Add(btnAbort);//Agregar botón

            return btnAbort;
        }
        private Button IgnoreButton(int locationX, int locationY)
        {//Crear botón ingnorar

            Button btnIgnore;
            btnIgnore = new Button();
            btnIgnore.Anchor = AnchorStyles.None;
            btnIgnore.BackColor = RJColors.Cancel;
            btnIgnore.FlatAppearance.BorderSize = 0;
            btnIgnore.FlatStyle = FlatStyle.Flat;
            btnIgnore.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btnIgnore.ForeColor = Color.WhiteSmoke;
            btnIgnore.Location = new Point(locationX, locationY);
            btnIgnore.Name = "btnIgnore";
            btnIgnore.Size = new Size(110, 35);
            btnIgnore.Text = "Ignore";
            btnIgnore.UseVisualStyleBackColor = false;

            btnIgnore.DialogResult = DialogResult.Ignore;//Establecer DialogResult

            pnlButtons.Controls.Add(btnIgnore);//Agregar botón

            return btnIgnore;
        }
        #endregion

        #region Form events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion
    }
}
