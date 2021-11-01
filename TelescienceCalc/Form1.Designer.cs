namespace TelescienceCalc
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.power = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationY = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.destinationX = new System.Windows.Forms.TextBox();
            this.saveLocation = new System.Windows.Forms.Button();
            this.loadLocation = new System.Windows.Forms.Button();
            this.deleteLocation = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.dataLocation = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.powerOFFSETlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bearingOFFSETlabel = new System.Windows.Forms.Label();
            this.calibrateDialog = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.elevation = new System.Windows.Forms.TextBox();
            this.bearing = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.recommendedCalibration = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.decreaseCalibration = new System.Windows.Forms.Button();
            this.increaseCalibration = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocation)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.power);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.destinationY);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.destinationX);
            this.groupBox1.Controls.Add(this.saveLocation);
            this.groupBox1.Controls.Add(this.loadLocation);
            this.groupBox1.Controls.Add(this.deleteLocation);
            this.groupBox1.Controls.Add(this.loadData);
            this.groupBox1.Controls.Add(this.saveData);
            this.groupBox1.Controls.Add(this.dataLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // power
            // 
            this.power.FormattingEnabled = true;
            this.power.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "25",
            "30",
            "40",
            "50",
            "80",
            "100"});
            this.power.Location = new System.Drawing.Point(87, 289);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(55, 21);
            this.power.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Power:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination X:";
            // 
            // destinationY
            // 
            this.destinationY.Location = new System.Drawing.Point(87, 263);
            this.destinationY.Name = "destinationY";
            this.destinationY.Size = new System.Drawing.Size(55, 20);
            this.destinationY.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(233, 263);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(134, 20);
            this.name.TabIndex = 2;
            this.name.TabStop = false;
            // 
            // destinationX
            // 
            this.destinationX.Location = new System.Drawing.Point(87, 237);
            this.destinationX.Name = "destinationX";
            this.destinationX.Size = new System.Drawing.Size(55, 20);
            this.destinationX.TabIndex = 0;
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(233, 287);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(134, 23);
            this.saveLocation.TabIndex = 1;
            this.saveLocation.TabStop = false;
            this.saveLocation.Text = "Save location";
            this.saveLocation.UseVisualStyleBackColor = true;
            this.saveLocation.Click += new System.EventHandler(this.saveLocation_Click);
            // 
            // loadLocation
            // 
            this.loadLocation.Location = new System.Drawing.Point(273, 208);
            this.loadLocation.Name = "loadLocation";
            this.loadLocation.Size = new System.Drawing.Size(94, 23);
            this.loadLocation.TabIndex = 1;
            this.loadLocation.TabStop = false;
            this.loadLocation.Text = "Load location";
            this.loadLocation.UseVisualStyleBackColor = true;
            this.loadLocation.Click += new System.EventHandler(this.loadLocation_Click);
            // 
            // deleteLocation
            // 
            this.deleteLocation.Location = new System.Drawing.Point(181, 208);
            this.deleteLocation.Name = "deleteLocation";
            this.deleteLocation.Size = new System.Drawing.Size(86, 23);
            this.deleteLocation.TabIndex = 1;
            this.deleteLocation.TabStop = false;
            this.deleteLocation.Text = "Delete location";
            this.deleteLocation.UseVisualStyleBackColor = true;
            this.deleteLocation.Click += new System.EventHandler(this.deleteLocation_Click);
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(87, 208);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(75, 23);
            this.loadData.TabIndex = 1;
            this.loadData.TabStop = false;
            this.loadData.Text = "Load data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(6, 208);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(75, 23);
            this.saveData.TabIndex = 1;
            this.saveData.TabStop = false;
            this.saveData.Text = "Save data";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // dataLocation
            // 
            this.dataLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLocation.Location = new System.Drawing.Point(6, 19);
            this.dataLocation.Name = "dataLocation";
            this.dataLocation.Size = new System.Drawing.Size(361, 183);
            this.dataLocation.TabIndex = 0;
            this.dataLocation.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.powerOFFSETlabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bearingOFFSETlabel);
            this.groupBox2.Controls.Add(this.calibrateDialog);
            this.groupBox2.Location = new System.Drawing.Point(391, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calibration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Power Offset:";
            // 
            // powerOFFSETlabel
            // 
            this.powerOFFSETlabel.AutoSize = true;
            this.powerOFFSETlabel.Location = new System.Drawing.Point(114, 19);
            this.powerOFFSETlabel.Name = "powerOFFSETlabel";
            this.powerOFFSETlabel.Size = new System.Drawing.Size(13, 13);
            this.powerOFFSETlabel.TabIndex = 3;
            this.powerOFFSETlabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bearing Offset:";
            // 
            // bearingOFFSETlabel
            // 
            this.bearingOFFSETlabel.AutoSize = true;
            this.bearingOFFSETlabel.Location = new System.Drawing.Point(114, 43);
            this.bearingOFFSETlabel.Name = "bearingOFFSETlabel";
            this.bearingOFFSETlabel.Size = new System.Drawing.Size(13, 13);
            this.bearingOFFSETlabel.TabIndex = 3;
            this.bearingOFFSETlabel.Text = "0";
            // 
            // calibrateDialog
            // 
            this.calibrateDialog.Location = new System.Drawing.Point(6, 70);
            this.calibrateDialog.Name = "calibrateDialog";
            this.calibrateDialog.Size = new System.Drawing.Size(152, 23);
            this.calibrateDialog.TabIndex = 1;
            this.calibrateDialog.TabStop = false;
            this.calibrateDialog.Text = "Calibrate";
            this.calibrateDialog.UseVisualStyleBackColor = true;
            this.calibrateDialog.Click += new System.EventHandler(this.calibrateDialog_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.elevation);
            this.groupBox3.Controls.Add(this.bearing);
            this.groupBox3.Controls.Add(this.calculate);
            this.groupBox3.Location = new System.Drawing.Point(391, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 108);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elevation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bearing:";
            // 
            // elevation
            // 
            this.elevation.Location = new System.Drawing.Point(93, 43);
            this.elevation.Name = "elevation";
            this.elevation.Size = new System.Drawing.Size(68, 20);
            this.elevation.TabIndex = 1;
            this.elevation.TabStop = false;
            // 
            // bearing
            // 
            this.bearing.Location = new System.Drawing.Point(93, 17);
            this.bearing.Name = "bearing";
            this.bearing.Size = new System.Drawing.Size(68, 20);
            this.bearing.TabIndex = 0;
            this.bearing.TabStop = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(9, 79);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(152, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.recommendedCalibration);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.decreaseCalibration);
            this.groupBox4.Controls.Add(this.increaseCalibration);
            this.groupBox4.Location = new System.Drawing.Point(391, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recommendation";
            // 
            // recommendedCalibration
            // 
            this.recommendedCalibration.AutoSize = true;
            this.recommendedCalibration.Location = new System.Drawing.Point(107, 22);
            this.recommendedCalibration.Name = "recommendedCalibration";
            this.recommendedCalibration.Size = new System.Drawing.Size(19, 13);
            this.recommendedCalibration.TabIndex = 6;
            this.recommendedCalibration.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Next calibration:";
            // 
            // decreaseCalibration
            // 
            this.decreaseCalibration.Location = new System.Drawing.Point(86, 43);
            this.decreaseCalibration.Name = "decreaseCalibration";
            this.decreaseCalibration.Size = new System.Drawing.Size(75, 23);
            this.decreaseCalibration.TabIndex = 1;
            this.decreaseCalibration.TabStop = false;
            this.decreaseCalibration.Text = "Decrease";
            this.decreaseCalibration.UseVisualStyleBackColor = true;
            this.decreaseCalibration.Click += new System.EventHandler(this.decreaseCalibration_Click);
            // 
            // increaseCalibration
            // 
            this.increaseCalibration.Location = new System.Drawing.Point(6, 43);
            this.increaseCalibration.Name = "increaseCalibration";
            this.increaseCalibration.Size = new System.Drawing.Size(75, 23);
            this.increaseCalibration.TabIndex = 1;
            this.increaseCalibration.TabStop = false;
            this.increaseCalibration.Text = "Increase";
            this.increaseCalibration.UseVisualStyleBackColor = true;
            this.increaseCalibration.Click += new System.EventHandler(this.increaseCalibration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 340);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLocation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox destinationX;
        private System.Windows.Forms.Button loadLocation;
        private System.Windows.Forms.Button deleteLocation;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.DataGridView dataLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox power;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button saveLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox elevation;
        private System.Windows.Forms.TextBox bearing;
        private System.Windows.Forms.Button calibrateDialog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label powerOFFSETlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bearingOFFSETlabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label recommendedCalibration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button decreaseCalibration;
        private System.Windows.Forms.Button increaseCalibration;
    }
}

