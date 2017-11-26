namespace Exxxplorer
{
    partial class Explrr
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
            this.Discsinfo = new System.Windows.Forms.DataGridView();
            this.Drivers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirInfo = new System.Windows.Forms.DataGridView();
            this.Looking_for_what = new System.Windows.Forms.TextBox();
            this.goBack = new System.Windows.Forms.Button();
            this.tip1 = new System.Windows.Forms.Label();
            this.type_search = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.Label();
            this.Naaaame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizeee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Discsinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // Discsinfo
            // 
            this.Discsinfo.AllowUserToAddRows = false;
            this.Discsinfo.AllowUserToDeleteRows = false;
            this.Discsinfo.AllowUserToResizeColumns = false;
            this.Discsinfo.AllowUserToResizeRows = false;
            this.Discsinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Discsinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drivers});
            this.Discsinfo.Location = new System.Drawing.Point(409, 12);
            this.Discsinfo.MultiSelect = false;
            this.Discsinfo.Name = "Discsinfo";
            this.Discsinfo.ReadOnly = true;
            this.Discsinfo.RowHeadersVisible = false;
            this.Discsinfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Discsinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Discsinfo.Size = new System.Drawing.Size(105, 149);
            this.Discsinfo.TabIndex = 0;
            // 
            // Drivers
            // 
            this.Drivers.HeaderText = "Диски";
            this.Drivers.Name = "Drivers";
            this.Drivers.ReadOnly = true;
            // 
            // DirInfo
            // 
            this.DirInfo.AllowUserToAddRows = false;
            this.DirInfo.AllowUserToDeleteRows = false;
            this.DirInfo.AllowUserToResizeColumns = false;
            this.DirInfo.AllowUserToResizeRows = false;
            this.DirInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DirInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naaaame,
            this.Type,
            this.Sizeee});
            this.DirInfo.Location = new System.Drawing.Point(2, 198);
            this.DirInfo.MultiSelect = false;
            this.DirInfo.Name = "DirInfo";
            this.DirInfo.ReadOnly = true;
            this.DirInfo.RowHeadersVisible = false;
            this.DirInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DirInfo.Size = new System.Drawing.Size(512, 309);
            this.DirInfo.TabIndex = 1;
            this.DirInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dir_Info_2Click);
            // 
            // Looking_for_what
            // 
            this.Looking_for_what.Location = new System.Drawing.Point(2, 38);
            this.Looking_for_what.Name = "Looking_for_what";
            this.Looking_for_what.Size = new System.Drawing.Size(160, 20);
            this.Looking_for_what.TabIndex = 2;
            this.Looking_for_what.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Looking_for_what_KeyUp);
            // 
            // goBack
            // 
            this.goBack.Enabled = false;
            this.goBack.Location = new System.Drawing.Point(330, 108);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(73, 53);
            this.goBack.TabIndex = 3;
            this.goBack.Text = "Назад";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.Backward_Click);
            // 
            // tip1
            // 
            this.tip1.Location = new System.Drawing.Point(281, 9);
            this.tip1.Name = "tip1";
            this.tip1.Size = new System.Drawing.Size(122, 23);
            this.tip1.TabIndex = 7;
            this.tip1.Text = "поиск по расширению";
            // 
            // type_search
            // 
            this.type_search.Location = new System.Drawing.Point(330, 38);
            this.type_search.Name = "type_search";
            this.type_search.Size = new System.Drawing.Size(73, 20);
            this.type_search.TabIndex = 8;
            this.type_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EXTNSION_SEARCH_KeyUp);
            // 
            // tip
            // 
            this.tip.Location = new System.Drawing.Point(-1, 12);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(199, 23);
            this.tip.TabIndex = 9;
            this.tip.Text = "Press print screen find what u need";
            // 
            // Naaaame
            // 
            this.Naaaame.HeaderText = "Название";
            this.Naaaame.Name = "Naaaame";
            this.Naaaame.ReadOnly = true;
            this.Naaaame.Width = 250;
            // 
            // Type
            // 
            this.Type.HeaderText = "Вид";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 120;
            // 
            // Sizeee
            // 
            this.Sizeee.HeaderText = "Размер";
            this.Sizeee.Name = "Sizeee";
            this.Sizeee.ReadOnly = true;
            this.Sizeee.Width = 120;
            // 
            // Explrr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 519);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.type_search);
            this.Controls.Add(this.tip1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.Looking_for_what);
            this.Controls.Add(this.DirInfo);
            this.Controls.Add(this.Discsinfo);
            this.Name = "Explrr";
            this.Text = "Проводник ";
            this.Load += new System.EventHandler(this.Explrr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Discsinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DirInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Discsinfo;
        private System.Windows.Forms.DataGridView DirInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drivers;
        private System.Windows.Forms.TextBox Looking_for_what;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label tip1;
        private System.Windows.Forms.TextBox type_search;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naaaame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sizeee;
    }
}

