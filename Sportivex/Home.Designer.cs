namespace Sportivex
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel4 = new Panel();
            txtDate = new Label();
            date = new Label();
            txtTransactionNo = new Label();
            trac = new Label();
            panel3 = new Panel();
            label14 = new Label();
            txtDiscount = new Label();
            txtTotal = new Label();
            label12 = new Label();
            btn_search = new Button();
            txtBarcode = new TextBox();
            label11 = new Label();
            panel1 = new Panel();
            bt_log = new Button();
            pumps = new Label();
            pedals = new Label();
            eyewear = new Label();
            locks = new Label();
            helmet = new Label();
            lb_Home = new Label();
            grips = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridViewProducts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(823, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(245, 494);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtDate);
            panel4.Controls.Add(date);
            panel4.Controls.Add(txtTransactionNo);
            panel4.Controls.Add(trac);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 143);
            panel4.TabIndex = 0;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Location = new Point(7, 86);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(57, 20);
            txtDate.TabIndex = 0;
            txtDate.Text = "000000";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date.Location = new Point(7, 60);
            date.Name = "date";
            date.Size = new Size(47, 18);
            date.TabIndex = 0;
            date.Text = "Date";
            // 
            // txtTransactionNo
            // 
            txtTransactionNo.AutoSize = true;
            txtTransactionNo.Location = new Point(7, 20);
            txtTransactionNo.Name = "txtTransactionNo";
            txtTransactionNo.Size = new Size(65, 20);
            txtTransactionNo.TabIndex = 0;
            txtTransactionNo.Text = "0000000";
            // 
            // trac
            // 
            trac.AutoSize = true;
            trac.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trac.Location = new Point(7, 0);
            trac.Name = "trac";
            trac.Size = new Size(135, 18);
            trac.TabIndex = 0;
            trac.Text = "Transaction No.";
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtDiscount);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(btn_search);
            panel3.Controls.Add(txtBarcode);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(3, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 298);
            panel3.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(8, 208);
            label14.Name = "label14";
            label14.Size = new Size(104, 18);
            label14.TabIndex = 0;
            label14.Text = "Sales Total:";
            // 
            // txtDiscount
            // 
            txtDiscount.AutoSize = true;
            txtDiscount.Location = new Point(189, 245);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(41, 20);
            txtDiscount.TabIndex = 0;
            txtDiscount.Text = "0000";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(189, 208);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(41, 20);
            txtTotal.TabIndex = 0;
            txtTotal.Text = "0000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(7, 245);
            label12.Name = "label12";
            label12.Size = new Size(84, 18);
            label12.TabIndex = 0;
            label12.Text = "Discount:";
            // 
            // btn_search
            // 
            btn_search.BackgroundImage = Properties.Resources.glass;
            btn_search.BackgroundImageLayout = ImageLayout.Stretch;
            btn_search.Font = new Font("Segoe UI", 10F);
            btn_search.Location = new Point(201, 43);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(29, 25);
            btn_search.TabIndex = 2;
            btn_search.UseVisualStyleBackColor = true;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcode.Location = new Point(7, 38);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(223, 34);
            txtBarcode.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(8, 15);
            label11.Name = "label11";
            label11.Size = new Size(74, 18);
            label11.TabIndex = 0;
            label11.Text = "Barcode";
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_log);
            panel1.Controls.Add(pumps);
            panel1.Controls.Add(pedals);
            panel1.Controls.Add(eyewear);
            panel1.Controls.Add(locks);
            panel1.Controls.Add(helmet);
            panel1.Controls.Add(lb_Home);
            panel1.Controls.Add(grips);
            panel1.Location = new Point(3, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 405);
            panel1.TabIndex = 1;
            // 
            // bt_log
            // 
            bt_log.Font = new Font("Verdana", 9F, FontStyle.Bold);
            bt_log.Location = new Point(27, 364);
            bt_log.Name = "bt_log";
            bt_log.Size = new Size(84, 29);
            bt_log.TabIndex = 1;
            bt_log.Text = "Log Out";
            bt_log.UseVisualStyleBackColor = true;
            // 
            // pumps
            // 
            pumps.AutoSize = true;
            pumps.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            pumps.Location = new Point(27, 298);
            pumps.Name = "pumps";
            pumps.Size = new Size(75, 20);
            pumps.TabIndex = 0;
            pumps.Text = "PUMPS";
            pumps.Click += pumps_Click;
            // 
            // pedals
            // 
            pedals.AutoSize = true;
            pedals.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            pedals.Location = new Point(27, 254);
            pedals.Name = "pedals";
            pedals.Size = new Size(83, 20);
            pedals.TabIndex = 0;
            pedals.Text = "PEDALS";
            pedals.Click += pedals_Click;
            // 
            // eyewear
            // 
            eyewear.AutoSize = true;
            eyewear.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            eyewear.Location = new Point(27, 205);
            eyewear.Name = "eyewear";
            eyewear.Size = new Size(103, 20);
            eyewear.TabIndex = 0;
            eyewear.Text = "EYEWEAR";
            eyewear.Click += eyewear_Click;
            // 
            // locks
            // 
            locks.AutoSize = true;
            locks.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            locks.Location = new Point(27, 157);
            locks.Name = "locks";
            locks.Size = new Size(71, 20);
            locks.TabIndex = 0;
            locks.Text = "LOCKS";
            locks.Click += locks_Click;
            // 
            // helmet
            // 
            helmet.AutoSize = true;
            helmet.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            helmet.Location = new Point(27, 112);
            helmet.Name = "helmet";
            helmet.Size = new Size(98, 20);
            helmet.TabIndex = 0;
            helmet.Text = "HELMETS";
            helmet.Click += helmet_Click;
            // 
            // lb_Home
            // 
            lb_Home.AutoSize = true;
            lb_Home.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Home.ForeColor = Color.Transparent;
            lb_Home.Location = new Point(27, 24);
            lb_Home.Name = "lb_Home";
            lb_Home.Size = new Size(65, 20);
            lb_Home.TabIndex = 0;
            lb_Home.Text = "HOME";
            lb_Home.Click += home_Click;
            // 
            // grips
            // 
            grips.AutoSize = true;
            grips.Font = new Font("Verdana", 10.2F, FontStyle.Bold);
            grips.Location = new Point(27, 63);
            grips.Name = "grips";
            grips.Size = new Size(69, 20);
            grips.TabIndex = 0;
            grips.Text = "GRIPS";
            grips.Click += grips_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Group_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(151, 494);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(151, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(672, 494);
            dataGridViewProducts.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "No.";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Pcode";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Description";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Qty";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 494);
            Controls.Add(dataGridViewProducts);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Home";
            Text = "v";
            Load += Home_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Label txtDate;
        private Label date;
        private Label txtTransactionNo;
        private Label trac;
        private Panel panel3;
        private Label label14;
        private Label txtTotal;
        private Label label12;
        private TextBox txtBarcode;
        private Label label11;
        private Button btn_search;
        private Label txtDiscount;
        private Panel panel1;
        private Label pumps;
        private Label pedals;
        private Label eyewear;
        private Label locks;
        private Label helmet;
        private Label grips;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lb_Home;
        private Button bt_log;
    }
}