namespace STO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtostoyankaDataSet = new STO.AvtostoyankaDataSet();
            this.cARSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtostoyankaDataSet1 = new STO.AvtostoyankaDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sTODataSet1 = new STO.STODataSet1();
            this.sTODataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTODataSet = new STO.STODataSet();
            this.sTODataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new STO.AvtostoyankaDataSetTableAdapters.TableTableAdapter();
            this.cARSTableAdapter = new STO.AvtostoyankaDataSet1TableAdapters.CARSTableAdapter();
            this.sTO_DB = new STO.STO_DB();
            this.sTODBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTODBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtostoyankaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtostoyankaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTO_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODBBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по ГосНомеру";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.cARSBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 329);
            this.listBox1.TabIndex = 3;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.avtostoyankaDataSet;
            // 
            // avtostoyankaDataSet
            // 
            this.avtostoyankaDataSet.DataSetName = "AvtostoyankaDataSet";
            this.avtostoyankaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARSBindingSource
            // 
            this.cARSBindingSource.DataMember = "CARS";
            this.cARSBindingSource.DataSource = this.avtostoyankaDataSet1;
            // 
            // avtostoyankaDataSet1
            // 
            this.avtostoyankaDataSet1.DataSetName = "AvtostoyankaDataSet1";
            this.avtostoyankaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Открыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Создать новую запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sTODataSet1
            // 
            this.sTODataSet1.DataSetName = "STODataSet1";
            this.sTODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTODataSet1BindingSource
            // 
            this.sTODataSet1BindingSource.DataSource = this.sTODataSet1;
            this.sTODataSet1BindingSource.Position = 0;
            // 
            // sTODataSetBindingSource
            // 
            this.sTODataSetBindingSource.DataSource = this.sTODataSet;
            this.sTODataSetBindingSource.Position = 0;
            // 
            // sTODataSet
            // 
            this.sTODataSet.DataSetName = "STODataSet";
            this.sTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTODataSetBindingSource1
            // 
            this.sTODataSetBindingSource1.DataSource = this.sTODataSet;
            this.sTODataSetBindingSource1.Position = 0;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // cARSTableAdapter
            // 
            this.cARSTableAdapter.ClearBeforeFill = true;
            // 
            // sTO_DB
            // 
            this.sTO_DB.DataSetName = "STO_DB";
            this.sTO_DB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTODBBindingSource
            // 
            this.sTODBBindingSource.DataSource = this.sTO_DB;
            this.sTODBBindingSource.Position = 0;
            // 
            // sTODBBindingSource1
            // 
            this.sTODBBindingSource1.DataSource = this.sTO_DB;
            this.sTODBBindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 564);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Поиск автомобиля";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtostoyankaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtostoyankaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTO_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTODBBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource sTODataSetBindingSource;
        private STODataSet sTODataSet;
        private System.Windows.Forms.BindingSource sTODataSet1BindingSource;
        private STODataSet1 sTODataSet1;
        private System.Windows.Forms.BindingSource sTODataSetBindingSource1;
        private AvtostoyankaDataSet avtostoyankaDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private AvtostoyankaDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private AvtostoyankaDataSet1 avtostoyankaDataSet1;
        private System.Windows.Forms.BindingSource cARSBindingSource;
        private AvtostoyankaDataSet1TableAdapters.CARSTableAdapter cARSTableAdapter;
        private System.Windows.Forms.BindingSource sTODBBindingSource;
        private STO_DB sTO_DB;
        private System.Windows.Forms.BindingSource sTODBBindingSource1;
    }
}

