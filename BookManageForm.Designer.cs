namespace BookManageProgram
{
    partial class BookManageForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAllSelect = new System.Windows.Forms.Button();
            this.btnAllDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtSearchISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMeans = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.testdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testdbDataSet = new BookManageProgram.testdbDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.대출반납ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAllSelect
            // 
            this.btnAllSelect.Location = new System.Drawing.Point(0, 125);
            this.btnAllSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllSelect.Name = "btnAllSelect";
            this.btnAllSelect.Size = new System.Drawing.Size(201, 65);
            this.btnAllSelect.TabIndex = 1;
            this.btnAllSelect.Text = "전체 선택";
            this.btnAllSelect.UseVisualStyleBackColor = true;
            this.btnAllSelect.Click += new System.EventHandler(this.btnAllSelect_Click);
            // 
            // btnAllDel
            // 
            this.btnAllDel.Location = new System.Drawing.Point(682, 125);
            this.btnAllDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllDel.Name = "btnAllDel";
            this.btnAllDel.Size = new System.Drawing.Size(201, 65);
            this.btnAllDel.TabIndex = 2;
            this.btnAllDel.Text = "일괄 삭제";
            this.btnAllDel.UseVisualStyleBackColor = true;
            this.btnAllDel.Click += new System.EventHandler(this.btnAllDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1045, 204);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 50);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1340, 204);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1909, 204);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 50);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(959, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "등록번호";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(1151, 322);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(343, 42);
            this.txtNum.TabIndex = 9;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1538, 306);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(193, 68);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "불러오기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(959, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1468, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "도서정보 ISBN 검색";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(959, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(959, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "제목";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1533, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "저자";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(959, 760);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "도서설명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(959, 898);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "소장위치";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1335, 898);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "반입구분";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1710, 898);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "도서상태";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "자료실1",
            "자료실2",
            "자료실3"});
            this.comboBox1.Location = new System.Drawing.Point(1098, 895);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 38);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "자료실1";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "구매",
            "기부",
            "증정"});
            this.comboBox2.Location = new System.Drawing.Point(1473, 895);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 38);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Text = "구매";
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "대출가능",
            "대출불가능"});
            this.comboBox3.Location = new System.Drawing.Point(1849, 895);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(230, 38);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.Text = "대출가능";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(1072, 394);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(343, 42);
            this.txtISBN.TabIndex = 23;
            // 
            // txtSearchISBN
            // 
            this.txtSearchISBN.BackColor = System.Drawing.Color.Aquamarine;
            this.txtSearchISBN.Location = new System.Drawing.Point(1768, 394);
            this.txtSearchISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchISBN.Name = "txtSearchISBN";
            this.txtSearchISBN.Size = new System.Drawing.Size(266, 42);
            this.txtSearchISBN.TabIndex = 24;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(1072, 502);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(343, 42);
            this.txtTitle.TabIndex = 25;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(1643, 502);
            this.txtWriter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.ReadOnly = true;
            this.txtWriter.Size = new System.Drawing.Size(343, 42);
            this.txtWriter.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1062, 630);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(343, 42);
            this.txtPrice.TabIndex = 27;
            // 
            // txtMeans
            // 
            this.txtMeans.Location = new System.Drawing.Point(1108, 758);
            this.txtMeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeans.Name = "txtMeans";
            this.txtMeans.ReadOnly = true;
            this.txtMeans.Size = new System.Drawing.Size(559, 42);
            this.txtMeans.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(2062, 387);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 50);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new System.Drawing.Size(933, 745);
            this.dataGridView1.TabIndex = 30;
            // 
            // testdbDataSetBindingSource
            // 
            this.testdbDataSetBindingSource.DataSource = this.testdbDataSet;
            this.testdbDataSetBindingSource.Position = 0;
            // 
            // testdbDataSet
            // 
            this.testdbDataSet.DataSetName = "testdbDataSet";
            this.testdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.대출반납ToolStripMenuItem,
            this.도서관리ToolStripMenuItem,
            this.회원관리ToolStripMenuItem,
            this.도서검색ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2273, 49);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 대출반납ToolStripMenuItem
            // 
            this.대출반납ToolStripMenuItem.Name = "대출반납ToolStripMenuItem";
            this.대출반납ToolStripMenuItem.Size = new System.Drawing.Size(174, 45);
            this.대출반납ToolStripMenuItem.Text = "대출/반납";
            this.대출반납ToolStripMenuItem.Click += new System.EventHandler(this.대출반납ToolStripMenuItem_Click_1);
            // 
            // 도서관리ToolStripMenuItem
            // 
            this.도서관리ToolStripMenuItem.Name = "도서관리ToolStripMenuItem";
            this.도서관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 45);
            this.도서관리ToolStripMenuItem.Text = "도서관리";
            this.도서관리ToolStripMenuItem.Click += new System.EventHandler(this.도서관리ToolStripMenuItem_Click);
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(162, 45);
            this.회원관리ToolStripMenuItem.Text = "회원관리";
            this.회원관리ToolStripMenuItem.Click += new System.EventHandler(this.회원관리ToolStripMenuItem_Click);
            // 
            // 도서검색ToolStripMenuItem
            // 
            this.도서검색ToolStripMenuItem.Name = "도서검색ToolStripMenuItem";
            this.도서검색ToolStripMenuItem.Size = new System.Drawing.Size(162, 45);
            this.도서검색ToolStripMenuItem.Text = "도서검색";
            this.도서검색ToolStripMenuItem.Click += new System.EventHandler(this.도서검색ToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1468, 638);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 30);
            this.label11.TabIndex = 52;
            this.label11.Text = "출판사";
            // 
            // txtPub
            // 
            this.txtPub.Location = new System.Drawing.Point(1602, 630);
            this.txtPub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPub.Name = "txtPub";
            this.txtPub.ReadOnly = true;
            this.txtPub.Size = new System.Drawing.Size(343, 42);
            this.txtPub.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1656, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 50);
            this.button1.TabIndex = 54;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 125);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 65);
            this.button2.TabIndex = 55;
            this.button2.Text = "전체 확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2273, 1190);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPub);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMeans);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtSearchISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAllDel);
            this.Controls.Add(this.btnAllSelect);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookManageForm";
            this.Text = "BookManageForm";
            this.Load += new System.EventHandler(this.BookManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAllSelect;
        private System.Windows.Forms.Button btnAllDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtSearchISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMeans;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 대출반납ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서검색ToolStripMenuItem;
        private System.Windows.Forms.BindingSource testdbDataSetBindingSource;
        private testdbDataSet testdbDataSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

