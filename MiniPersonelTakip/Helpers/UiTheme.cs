using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MiniPersonelTakip.Helpers
{
    public static class UiTheme
    {
        public static readonly Color PageBack = Color.FromArgb(245, 247, 250);
        public static readonly Color Surface = Color.White;
        public static readonly Color SurfaceAlt = Color.FromArgb(249, 250, 252);
        public static readonly Color Border = Color.FromArgb(226, 232, 240);

        public static readonly Color Primary = Color.FromArgb(37, 99, 235);
        public static readonly Color Success = Color.FromArgb(22, 163, 74);
        public static readonly Color Warning = Color.FromArgb(245, 158, 11);
        public static readonly Color Danger = Color.FromArgb(220, 38, 38);
        public static readonly Color Secondary = Color.FromArgb(71, 85, 105);

        public static readonly Color Title = Color.FromArgb(15, 23, 42);
        public static readonly Color Text = Color.FromArgb(51, 65, 85);
        public static readonly Color Muted = Color.FromArgb(100, 116, 139);

        public static void StylePage(Form form)
        {
            form.BackColor = PageBack;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }

        public static void StyleSurface(Panel panel, int padding = 12)
        {
            panel.BackColor = Surface;
            panel.Padding = new Padding(padding);
        }

        public static void StyleHeaderPanel(Panel panel)
        {
            panel.BackColor = Surface;
            panel.Padding = new Padding(16, 14, 16, 14);
        }

        public static void StyleFilterPanel(Panel panel)
        {
            panel.BackColor = Surface;
            panel.Padding = new Padding(14);
        }

        public static void StyleActionPanel(Panel panel)
        {
            panel.BackColor = Surface;
            panel.Padding = new Padding(12);
        }

        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Text;
        }

        public static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Text;
        }

        public static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.ForeColor = Text;
            checkBox.AutoSize = true;
        }

        public static void StyleDatePicker(DateTimePicker picker)
        {
            picker.CalendarMonthBackground = Color.White;
            picker.CalendarForeColor = Text;
        }

        public static void StyleLabel(Label label, bool title = false, bool muted = false)
        {
            label.ForeColor = muted ? Muted : (title ? Title : Text);
            label.Font = title
                ? new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
                : new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.AutoSize = true;
        }

        public static void StylePrimaryButton(Button button)
        {
            StyleButton(button, Primary, Color.White);
        }

        public static void StyleSuccessButton(Button button)
        {
            StyleButton(button, Success, Color.White);
        }

        public static void StyleWarningButton(Button button)
        {
            StyleButton(button, Warning, Color.White);
        }

        public static void StyleDangerButton(Button button)
        {
            StyleButton(button, Danger, Color.White);
        }

        public static void StyleSecondaryButton(Button button)
        {
            StyleButton(button, Secondary, Color.White);
        }

        public static void StyleNeutralButton(Button button)
        {
            StyleButton(button, Color.White, Text);
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Border;
        }

        public static void StyleSidebarButton(Button button, Color color)
        {
            StyleButton(button, color, Color.White);
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(16, 0, 0, 0);
            button.Height = 46;
        }

        private static void StyleButton(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button.Height = 40;
            button.Cursor = Cursors.Hand;
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Border;
            grid.EnableHeadersVisualStyles = false;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Title;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Title;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(6);

            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.RowTemplate.Height = 36;

            try
            {
                typeof(DataGridView).InvokeMember(
                    "DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null,
                    grid,
                    new object[] { true });
            }
            catch
            {
            }
        }

        public static void StyleDialog(Form form)
        {
            form.BackColor = PageBack;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.StartPosition = FormStartPosition.CenterParent;
        }

        public static void StyleInputs(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        StyleTextBox(textBox);
                        break;
                    case ComboBox comboBox:
                        StyleComboBox(comboBox);
                        break;
                    case CheckBox checkBox:
                        StyleCheckBox(checkBox);
                        break;
                    case DateTimePicker picker:
                        StyleDatePicker(picker);
                        break;
                    case Label label:
                        if (label.Name.Contains("Baslik"))
                            StyleLabel(label, title: true);
                        else
                            StyleLabel(label);
                        break;
                    case Panel panel:
                        StyleInputs(panel);
                        break;
                }
            }
        }
    }
}
