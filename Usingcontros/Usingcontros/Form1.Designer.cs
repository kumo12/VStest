namespace Usingcontros
{
    partial class MainForm
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
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.rpTreeList = new System.Windows.Forms.ComboBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.IblFont = new System.Windows.Forms.Label();
            this.chkltalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.grpFont.SuspendLayout();
            this.grpBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpForm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.rpTreeList);
            this.grpFont.Controls.Add(this.txtSampleText);
            this.grpFont.Controls.Add(this.IblFont);
            this.grpFont.Controls.Add(this.chkltalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Location = new System.Drawing.Point(25, 13);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(749, 160);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox, CheckBox, TextBox";
            // 
            // rpTreeList
            // 
            this.rpTreeList.FormattingEnabled = true;
            this.rpTreeList.Location = new System.Drawing.Point(114, 48);
            this.rpTreeList.Name = "rpTreeList";
            this.rpTreeList.Size = new System.Drawing.Size(175, 20);
            this.rpTreeList.TabIndex = 5;
            this.rpTreeList.SelectedIndexChanged += new System.EventHandler(this.CboFont_SelectedIndexChanged);
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(73, 95);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(637, 21);
            this.txtSampleText.TabIndex = 4;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // IblFont
            // 
            this.IblFont.AutoSize = true;
            this.IblFont.Location = new System.Drawing.Point(71, 48);
            this.IblFont.Name = "IblFont";
            this.IblFont.Size = new System.Drawing.Size(37, 12);
            this.IblFont.TabIndex = 3;
            this.IblFont.Text = "Font :";
            this.IblFont.Click += new System.EventHandler(this.Label1_Click);
            // 
            // chkltalic
            // 
            this.chkltalic.AutoSize = true;
            this.chkltalic.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkltalic.Location = new System.Drawing.Point(448, 50);
            this.chkltalic.Name = "chkltalic";
            this.chkltalic.Size = new System.Drawing.Size(65, 17);
            this.chkltalic.TabIndex = 2;
            this.chkltalic.Text = "이탤릭";
            this.chkltalic.UseVisualStyleBackColor = true;
            this.chkltalic.CheckedChanged += new System.EventHandler(this.Chkltalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(331, 50);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(54, 17);
            this.chkBold.TabIndex = 0;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // grpBar
            // 
            this.grpBar.Controls.Add(this.groupBox1);
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Location = new System.Drawing.Point(25, 198);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(749, 133);
            this.grpBar.TabIndex = 1;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar && ProgressBar";
            this.grpBar.Enter += new System.EventHandler(this.GrpBar_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(8, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TrackBar && ProgressBar";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 50);
            this.progressBar1.Maximum = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(687, 58);
            this.progressBar1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 24);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(687, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(33, 72);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(687, 47);
            this.pgDummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(33, 21);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(687, 45);
            this.tbDummy.TabIndex = 0;
            this.tbDummy.Scroll += new System.EventHandler(this.TbDummy_Scroll);
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnMsgBox);
            this.grpForm.Controls.Add(this.btnModaless);
            this.grpForm.Controls.Add(this.btnModal);
            this.grpForm.Location = new System.Drawing.Point(25, 357);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(749, 57);
            this.grpForm.TabIndex = 3;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Modal && Modaless";
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(553, 20);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(157, 23);
            this.btnMsgBox.TabIndex = 2;
            this.btnMsgBox.Text = "MessageBox";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(282, 20);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(176, 23);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(41, 20);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(162, 23);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(27, 32);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(329, 182);
            this.tvDummy.TabIndex = 4;
            this.tvDummy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvDummy_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDummy);
            this.groupBox2.Controls.Add(this.btnAddChild);
            this.groupBox2.Controls.Add(this.btnAddRoot);
            this.groupBox2.Controls.Add(this.tvDummy);
            this.groupBox2.Location = new System.Drawing.Point(39, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 262);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modal && Modaless";
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(146, 220);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(107, 23);
            this.btnAddChild.TabIndex = 6;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(40, 220);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(100, 23);
            this.btnAddRoot.TabIndex = 3;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(382, 32);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(353, 182);
            this.lvDummy.TabIndex = 7;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 725);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.grpBar);
            this.Controls.Add(this.grpFont);
            this.Name = "MainForm";
            this.Text = "Control Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpForm.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Label IblFont;
        private System.Windows.Forms.CheckBox chkltalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.ComboBox rpTreeList;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.ListView lvDummy;
    }
}

