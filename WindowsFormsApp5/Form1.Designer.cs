
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addressDataGrid = new System.Windows.Forms.DataGridView();
            this.名前DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.郵便番号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.都道府県DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.市町村DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.番地DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressDateSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addressDateSet = new WindowsFormsApp5.AddressDateSet();
            this.ad = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.adf = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.prefectureBox = new System.Windows.Forms.TextBox();
            this.municipalityBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.w = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.postCodeBox = new System.Windows.Forms.MaskedTextBox();
            this.addressDateSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDateSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDateSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDateSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressDataGrid
            // 
            this.addressDataGrid.AutoGenerateColumns = false;
            this.addressDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名前DataGridViewTextBoxColumn,
            this.郵便番号DataGridViewTextBoxColumn,
            this.都道府県DataGridViewTextBoxColumn,
            this.市町村DataGridViewTextBoxColumn,
            this.番地DataGridViewTextBoxColumn});
            this.addressDataGrid.DataSource = this.addressDataTableBindingSource;
            this.addressDataGrid.Location = new System.Drawing.Point(13, 13);
            this.addressDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.addressDataGrid.Name = "addressDataGrid";
            this.addressDataGrid.RowHeadersWidth = 51;
            this.addressDataGrid.RowTemplate.Height = 21;
            this.addressDataGrid.Size = new System.Drawing.Size(1473, 338);
            this.addressDataGrid.TabIndex = 0;
            // 
            // 名前DataGridViewTextBoxColumn
            // 
            this.名前DataGridViewTextBoxColumn.DataPropertyName = "名前";
            this.名前DataGridViewTextBoxColumn.HeaderText = "名前";
            this.名前DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.名前DataGridViewTextBoxColumn.Name = "名前DataGridViewTextBoxColumn";
            this.名前DataGridViewTextBoxColumn.Width = 125;
            // 
            // 郵便番号DataGridViewTextBoxColumn
            // 
            this.郵便番号DataGridViewTextBoxColumn.DataPropertyName = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.HeaderText = "郵便番号";
            this.郵便番号DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.郵便番号DataGridViewTextBoxColumn.Name = "郵便番号DataGridViewTextBoxColumn";
            this.郵便番号DataGridViewTextBoxColumn.Width = 125;
            // 
            // 都道府県DataGridViewTextBoxColumn
            // 
            this.都道府県DataGridViewTextBoxColumn.DataPropertyName = "都道府県";
            this.都道府県DataGridViewTextBoxColumn.HeaderText = "都道府県";
            this.都道府県DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.都道府県DataGridViewTextBoxColumn.Name = "都道府県DataGridViewTextBoxColumn";
            this.都道府県DataGridViewTextBoxColumn.Width = 125;
            // 
            // 市町村DataGridViewTextBoxColumn
            // 
            this.市町村DataGridViewTextBoxColumn.DataPropertyName = "市町村";
            this.市町村DataGridViewTextBoxColumn.HeaderText = "市町村";
            this.市町村DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.市町村DataGridViewTextBoxColumn.Name = "市町村DataGridViewTextBoxColumn";
            this.市町村DataGridViewTextBoxColumn.Width = 125;
            // 
            // 番地DataGridViewTextBoxColumn
            // 
            this.番地DataGridViewTextBoxColumn.DataPropertyName = "番地";
            this.番地DataGridViewTextBoxColumn.HeaderText = "番地";
            this.番地DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.番地DataGridViewTextBoxColumn.Name = "番地DataGridViewTextBoxColumn";
            this.番地DataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataTableBindingSource
            // 
            this.addressDataTableBindingSource.DataMember = "addressDataTable";
            this.addressDataTableBindingSource.DataSource = this.addressDateSetBindingSource1;
            // 
            // addressDateSetBindingSource1
            // 
            this.addressDateSetBindingSource1.DataSource = this.addressDateSet;
            this.addressDateSetBindingSource1.Position = 0;
            // 
            // addressDateSet
            // 
            this.addressDateSet.DataSetName = "AddressDateSet";
            this.addressDateSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ad.Location = new System.Drawing.Point(48, 375);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(117, 38);
            this.ad.TabIndex = 1;
            this.ad.Text = "郵便番号";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.a.Location = new System.Drawing.Point(48, 412);
            this.a.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(117, 38);
            this.a.TabIndex = 2;
            this.a.Text = "都道府県";
            // 
            // adf
            // 
            this.adf.AutoSize = true;
            this.adf.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.adf.Location = new System.Drawing.Point(48, 454);
            this.adf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adf.Name = "adf";
            this.adf.Size = new System.Drawing.Size(92, 38);
            this.adf.TabIndex = 3;
            this.adf.Text = "市町村";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.r.Location = new System.Drawing.Point(48, 492);
            this.r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(67, 38);
            this.r.TabIndex = 4;
            this.r.Text = "番地";
            // 
            // prefectureBox
            // 
            this.prefectureBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.prefectureBox.Location = new System.Drawing.Point(205, 412);
            this.prefectureBox.Margin = new System.Windows.Forms.Padding(4);
            this.prefectureBox.Name = "prefectureBox";
            this.prefectureBox.Size = new System.Drawing.Size(464, 27);
            this.prefectureBox.TabIndex = 6;
            // 
            // municipalityBox
            // 
            this.municipalityBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.municipalityBox.Location = new System.Drawing.Point(205, 454);
            this.municipalityBox.Margin = new System.Windows.Forms.Padding(4);
            this.municipalityBox.Name = "municipalityBox";
            this.municipalityBox.Size = new System.Drawing.Size(464, 27);
            this.municipalityBox.TabIndex = 7;
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.addressBox.Location = new System.Drawing.Point(205, 492);
            this.addressBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(464, 27);
            this.addressBox.TabIndex = 8;
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.w.Location = new System.Drawing.Point(48, 534);
            this.w.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(67, 38);
            this.w.TabIndex = 9;
            this.w.Text = "名前";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.nameBox.Location = new System.Drawing.Point(205, 534);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(464, 27);
            this.nameBox.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("メイリオ", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.addButton.Location = new System.Drawing.Point(763, 412);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(287, 150);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("メイリオ", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.delButton.Location = new System.Drawing.Point(1131, 412);
            this.delButton.Margin = new System.Windows.Forms.Padding(4);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(287, 150);
            this.delButton.TabIndex = 12;
            this.delButton.Text = "削除";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButtonClicked);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.search.Location = new System.Drawing.Point(457, 375);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(213, 34);
            this.search.TabIndex = 13;
            this.search.Text = "郵便番号検索";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.SearchButtonClicked);
            // 
            // postCodeBox
            // 
            this.postCodeBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.postCodeBox.Location = new System.Drawing.Point(205, 375);
            this.postCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.postCodeBox.Mask = "000-0000";
            this.postCodeBox.Name = "postCodeBox";
            this.postCodeBox.Size = new System.Drawing.Size(212, 32);
            this.postCodeBox.TabIndex = 14;
            // 
            // addressDateSetBindingSource
            // 
            this.addressDateSetBindingSource.DataSource = this.addressDateSet;
            this.addressDateSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 629);
            this.Controls.Add(this.postCodeBox);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.w);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.municipalityBox);
            this.Controls.Add(this.prefectureBox);
            this.Controls.Add(this.r);
            this.Controls.Add(this.adf);
            this.Controls.Add(this.a);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.addressDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDateSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDateSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDateSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addressDataGrid;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label adf;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.TextBox prefectureBox;
        private System.Windows.Forms.TextBox municipalityBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.MaskedTextBox postCodeBox;
        private System.Windows.Forms.BindingSource addressDateSetBindingSource1;
        private AddressDateSet addressDateSet;
        private System.Windows.Forms.BindingSource addressDateSetBindingSource;
        private System.Windows.Forms.BindingSource addressDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 郵便番号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 都道府県DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 市町村DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 番地DataGridViewTextBoxColumn;
    }
}

