namespace Semana_3._2__List__A.DA.FA.S__BibliotecaLibros_.NET_6._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dateTimePickerFecha = new DateTimePicker();
            textBoxCodigo = new TextBox();
            textBoxTitulo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxAutor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDownStock = new NumericUpDown();
            comboBoxGenero = new ComboBox();
            buttonLimpiar = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            label8 = new Label();
            buttonOrdenar = new Button();
            buttonEliminarTodo = new Button();
            buttonEliminar = new Button();
            buttonRegistrar = new Button();
            labelTotalStock = new Label();
            labelTotalRegistros = new Label();
            label9 = new Label();
            label10 = new Label();
            listViewLibros = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(174, 18);
            label1.Name = "label1";
            label1.Size = new Size(466, 22);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE LOS LIBROS DE LA BIBLIOTECA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(39, 73);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 1;
            label2.Text = "CÓDIGO :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.ForeColor = Color.DarkRed;
            groupBox1.Location = new Point(39, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(835, 51);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(652, 104);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(222, 23);
            dateTimePickerFecha.TabIndex = 3;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(113, 71);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(89, 23);
            textBoxCodigo.TabIndex = 4;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(642, 71);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(232, 23);
            textBoxTitulo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(574, 73);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 5;
            label3.Text = "TÍTULO :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(39, 107);
            label4.Name = "label4";
            label4.Size = new Size(68, 18);
            label4.TabIndex = 7;
            label4.Text = "GÉNERO :";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(331, 71);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(190, 23);
            textBoxAutor.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(264, 73);
            label5.Name = "label5";
            label5.Size = new Size(58, 18);
            label5.TabIndex = 9;
            label5.Text = "AUTOR :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(473, 107);
            label6.Name = "label6";
            label6.Size = new Size(169, 18);
            label6.TabIndex = 11;
            label6.Text = "FECHA DE PUBLICACIÓN :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(298, 106);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 12;
            label7.Text = "STOCK :";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(364, 104);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(58, 23);
            numericUpDownStock.TabIndex = 13;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Ficción", "Drama", "Terror", "Humor", "Política", "Autobiografía" });
            comboBoxGenero.Location = new Point(116, 104);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 14;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.LightGray;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.Location = new Point(742, 205);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(83, 23);
            buttonLimpiar.TabIndex = 23;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.LightGray;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Location = new Point(648, 205);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(83, 23);
            buttonBuscar.TabIndex = 22;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(233, 205);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(373, 23);
            textBoxBuscar.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(91, 209);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 20;
            label8.Text = "BUSCAR POR CÓDIGO :";
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.BackColor = Color.Tan;
            buttonOrdenar.FlatStyle = FlatStyle.Popup;
            buttonOrdenar.Font = new Font("Square721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrdenar.ForeColor = Color.White;
            buttonOrdenar.Location = new Point(662, 150);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(163, 28);
            buttonOrdenar.TabIndex = 19;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = false;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // buttonEliminarTodo
            // 
            buttonEliminarTodo.BackColor = Color.Tan;
            buttonEliminarTodo.FlatStyle = FlatStyle.Popup;
            buttonEliminarTodo.Font = new Font("Square721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminarTodo.ForeColor = Color.White;
            buttonEliminarTodo.Location = new Point(471, 150);
            buttonEliminarTodo.Name = "buttonEliminarTodo";
            buttonEliminarTodo.Size = new Size(163, 28);
            buttonEliminarTodo.TabIndex = 18;
            buttonEliminarTodo.Text = "Eliminar Todo";
            buttonEliminarTodo.UseVisualStyleBackColor = false;
            buttonEliminarTodo.Click += buttonEliminarTodo_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Tan;
            buttonEliminar.FlatStyle = FlatStyle.Popup;
            buttonEliminar.Font = new Font("Square721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(282, 150);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(163, 28);
            buttonEliminar.TabIndex = 17;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Tan;
            buttonRegistrar.FlatStyle = FlatStyle.Popup;
            buttonRegistrar.Font = new Font("Square721 BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(91, 150);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(163, 28);
            buttonRegistrar.TabIndex = 16;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // labelTotalStock
            // 
            labelTotalStock.AutoSize = true;
            labelTotalStock.Location = new Point(684, 467);
            labelTotalStock.Name = "labelTotalStock";
            labelTotalStock.Size = new Size(13, 15);
            labelTotalStock.TabIndex = 28;
            labelTotalStock.Text = "0";
            // 
            // labelTotalRegistros
            // 
            labelTotalRegistros.AutoSize = true;
            labelTotalRegistros.Location = new Point(412, 467);
            labelTotalRegistros.Name = "labelTotalRegistros";
            labelTotalRegistros.Size = new Size(13, 15);
            labelTotalRegistros.TabIndex = 27;
            labelTotalRegistros.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(561, 467);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 26;
            label9.Text = "TOTAL EN STOCK :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(208, 467);
            label10.Name = "label10";
            label10.Size = new Size(180, 15);
            label10.TabIndex = 25;
            label10.Text = "TOTAL DE LIBROS REGISTRADOS :";
            // 
            // listViewLibros
            // 
            listViewLibros.BackColor = Color.WhiteSmoke;
            listViewLibros.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewLibros.Location = new Point(39, 255);
            listViewLibros.Name = "listViewLibros";
            listViewLibros.Size = new Size(835, 196);
            listViewLibros.TabIndex = 24;
            listViewLibros.UseCompatibleStateImageBehavior = false;
            listViewLibros.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Autor";
            columnHeader2.Width = 190;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Título";
            columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Género";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Stock";
            columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha de Publicación";
            columnHeader6.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(912, 510);
            Controls.Add(labelTotalStock);
            Controls.Add(labelTotalRegistros);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(listViewLibros);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonOrdenar);
            Controls.Add(buttonEliminarTodo);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonRegistrar);
            Controls.Add(comboBoxGenero);
            Controls.Add(numericUpDownStock);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxTitulo);
            Controls.Add(textBoxCodigo);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerFecha;
        private TextBox textBoxCodigo;
        private TextBox textBoxTitulo;
        private Label label3;
        private Label label4;
        private TextBox textBoxAutor;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownStock;
        private ComboBox comboBoxGenero;
        private Button buttonLimpiar;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private Label label8;
        private Button buttonOrdenar;
        private Button buttonEliminarTodo;
        private Button buttonEliminar;
        private Button buttonRegistrar;
        private Label labelTotalStock;
        private Label labelTotalRegistros;
        private Label label9;
        private Label label10;
        private ListView listViewLibros;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}