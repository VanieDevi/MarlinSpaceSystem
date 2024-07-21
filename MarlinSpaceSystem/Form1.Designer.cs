namespace MarlinSpaceSystem
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
            listViewBoth = new ListView();
            numericUpDownSigma = new NumericUpDown();
            numericUpDownMu = new NumericUpDown();
            btnLoad = new Button();
            labelSigma = new Label();
            labelMu = new Label();
            listBoxSensorA = new ListBox();
            listBoxSensorB = new ListBox();
            btnBSearchIterative_A = new Button();
            buttonBSearchRecursive_A = new Button();
            btnSelectionSort_A = new Button();
            buttonInsertionSort_A = new Button();
            btnBSearchIterative_B = new Button();
            btnBSearchRecursive_B = new Button();
            btnSelectionSort_B = new Button();
            btnInsertionSort_B = new Button();
            labelBSearchIterative_A = new Label();
            labelBSearchRecursive_A = new Label();
            labelSelectionSort_A = new Label();
            labelInsertionSort_A = new Label();
            labelBSearchIterative_B = new Label();
            labelBSearchRecursive_B = new Label();
            labelSelectionSort_B = new Label();
            labelInsertionSort_B = new Label();
            textBoxBSearchIterative_A = new TextBox();
            textBoxBSearchRecursive_A = new TextBox();
            textBoxSelectionSort_A = new TextBox();
            textBoxInsertionSort_A = new TextBox();
            textBoxSearchTarget_A = new TextBox();
            labelSearch_A = new Label();
            textBoxBSearchIterative_B = new TextBox();
            textBoxBSearchRecursive_B = new TextBox();
            textBoxSelectionSort_B = new TextBox();
            textBoxInsertionSort_B = new TextBox();
            textBoxSearchTarget_B = new TextBox();
            labelSearch_B = new Label();
            labelSensorA = new Label();
            labelSensorB = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSigma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMu).BeginInit();
            SuspendLayout();
            // 
            // listViewBoth
            // 
            listViewBoth.Location = new Point(39, 93);
            listViewBoth.Name = "listViewBoth";
            listViewBoth.Size = new Size(138, 345);
            listViewBoth.TabIndex = 0;
            listViewBoth.UseCompatibleStateImageBehavior = false;
            // 
            // numericUpDownSigma
            // 
            numericUpDownSigma.Location = new Point(48, 20);
            numericUpDownSigma.Name = "numericUpDownSigma";
            numericUpDownSigma.Size = new Size(31, 23);
            numericUpDownSigma.TabIndex = 1;
            // 
            // numericUpDownMu
            // 
            numericUpDownMu.Location = new Point(119, 20);
            numericUpDownMu.Name = "numericUpDownMu";
            numericUpDownMu.Size = new Size(32, 23);
            numericUpDownMu.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(48, 56);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(118, 23);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load Server Data";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // labelSigma
            // 
            labelSigma.AutoSize = true;
            labelSigma.Location = new Point(48, 2);
            labelSigma.Name = "labelSigma";
            labelSigma.Size = new Size(40, 15);
            labelSigma.TabIndex = 4;
            labelSigma.Text = "Sigma";
            // 
            // labelMu
            // 
            labelMu.AutoSize = true;
            labelMu.Location = new Point(119, 2);
            labelMu.Name = "labelMu";
            labelMu.Size = new Size(25, 15);
            labelMu.TabIndex = 5;
            labelMu.Text = "Mu";
            // 
            // listBoxSensorA
            // 
            listBoxSensorA.FormattingEnabled = true;
            listBoxSensorA.ItemHeight = 15;
            listBoxSensorA.Location = new Point(422, 56);
            listBoxSensorA.Name = "listBoxSensorA";
            listBoxSensorA.Size = new Size(100, 379);
            listBoxSensorA.TabIndex = 6;
            // 
            // listBoxSensorB
            // 
            listBoxSensorB.FormattingEnabled = true;
            listBoxSensorB.ItemHeight = 15;
            listBoxSensorB.Location = new Point(706, 59);
            listBoxSensorB.Name = "listBoxSensorB";
            listBoxSensorB.Size = new Size(95, 379);
            listBoxSensorB.TabIndex = 7;
            // 
            // btnBSearchIterative_A
            // 
            btnBSearchIterative_A.Location = new Point(271, 72);
            btnBSearchIterative_A.Name = "btnBSearchIterative_A";
            btnBSearchIterative_A.Size = new Size(75, 23);
            btnBSearchIterative_A.TabIndex = 8;
            btnBSearchIterative_A.Text = "Search";
            btnBSearchIterative_A.UseVisualStyleBackColor = true;
            // 
            // buttonBSearchRecursive_A
            // 
            buttonBSearchRecursive_A.Location = new Point(271, 187);
            buttonBSearchRecursive_A.Name = "buttonBSearchRecursive_A";
            buttonBSearchRecursive_A.Size = new Size(75, 23);
            buttonBSearchRecursive_A.TabIndex = 9;
            buttonBSearchRecursive_A.Text = "Search";
            buttonBSearchRecursive_A.UseVisualStyleBackColor = true;
            // 
            // btnSelectionSort_A
            // 
            btnSelectionSort_A.Location = new Point(271, 312);
            btnSelectionSort_A.Name = "btnSelectionSort_A";
            btnSelectionSort_A.Size = new Size(75, 23);
            btnSelectionSort_A.TabIndex = 10;
            btnSelectionSort_A.Text = "Sort";
            btnSelectionSort_A.UseVisualStyleBackColor = true;
            // 
            // buttonInsertionSort_A
            // 
            buttonInsertionSort_A.Location = new Point(271, 412);
            buttonInsertionSort_A.Name = "buttonInsertionSort_A";
            buttonInsertionSort_A.Size = new Size(75, 23);
            buttonInsertionSort_A.TabIndex = 11;
            buttonInsertionSort_A.Text = "Sort";
            buttonInsertionSort_A.UseVisualStyleBackColor = true;
            // 
            // btnBSearchIterative_B
            // 
            btnBSearchIterative_B.Location = new Point(565, 84);
            btnBSearchIterative_B.Name = "btnBSearchIterative_B";
            btnBSearchIterative_B.Size = new Size(75, 23);
            btnBSearchIterative_B.TabIndex = 12;
            btnBSearchIterative_B.Text = "Search";
            btnBSearchIterative_B.UseVisualStyleBackColor = true;
            // 
            // btnBSearchRecursive_B
            // 
            btnBSearchRecursive_B.Location = new Point(565, 187);
            btnBSearchRecursive_B.Name = "btnBSearchRecursive_B";
            btnBSearchRecursive_B.Size = new Size(75, 23);
            btnBSearchRecursive_B.TabIndex = 13;
            btnBSearchRecursive_B.Text = "Search";
            btnBSearchRecursive_B.UseVisualStyleBackColor = true;
            // 
            // btnSelectionSort_B
            // 
            btnSelectionSort_B.Location = new Point(565, 312);
            btnSelectionSort_B.Name = "btnSelectionSort_B";
            btnSelectionSort_B.Size = new Size(75, 23);
            btnSelectionSort_B.TabIndex = 14;
            btnSelectionSort_B.Text = "Sort";
            btnSelectionSort_B.UseVisualStyleBackColor = true;
            // 
            // btnInsertionSort_B
            // 
            btnInsertionSort_B.Location = new Point(565, 415);
            btnInsertionSort_B.Name = "btnInsertionSort_B";
            btnInsertionSort_B.Size = new Size(75, 23);
            btnInsertionSort_B.TabIndex = 15;
            btnInsertionSort_B.Text = "Sort";
            btnInsertionSort_B.UseVisualStyleBackColor = true;
            // 
            // labelBSearchIterative_A
            // 
            labelBSearchIterative_A.AutoSize = true;
            labelBSearchIterative_A.Location = new Point(271, 54);
            labelBSearchIterative_A.Name = "labelBSearchIterative_A";
            labelBSearchIterative_A.Size = new Size(123, 15);
            labelBSearchIterative_A.TabIndex = 16;
            labelBSearchIterative_A.Text = "Binary Search Iterative";
            // 
            // labelBSearchRecursive_A
            // 
            labelBSearchRecursive_A.AutoSize = true;
            labelBSearchRecursive_A.Location = new Point(271, 169);
            labelBSearchRecursive_A.Name = "labelBSearchRecursive_A";
            labelBSearchRecursive_A.Size = new Size(130, 15);
            labelBSearchRecursive_A.TabIndex = 17;
            labelBSearchRecursive_A.Text = "Binary search Recursive";
            // 
            // labelSelectionSort_A
            // 
            labelSelectionSort_A.AutoSize = true;
            labelSelectionSort_A.Location = new Point(271, 294);
            labelSelectionSort_A.Name = "labelSelectionSort_A";
            labelSelectionSort_A.Size = new Size(73, 15);
            labelSelectionSort_A.TabIndex = 18;
            labelSelectionSort_A.Text = "Seletion Sort";
            // 
            // labelInsertionSort_A
            // 
            labelInsertionSort_A.AutoSize = true;
            labelInsertionSort_A.Location = new Point(271, 394);
            labelInsertionSort_A.Name = "labelInsertionSort_A";
            labelInsertionSort_A.Size = new Size(77, 15);
            labelInsertionSort_A.TabIndex = 19;
            labelInsertionSort_A.Text = "Insertion Sort";
            // 
            // labelBSearchIterative_B
            // 
            labelBSearchIterative_B.AutoSize = true;
            labelBSearchIterative_B.Location = new Point(559, 66);
            labelBSearchIterative_B.Name = "labelBSearchIterative_B";
            labelBSearchIterative_B.Size = new Size(123, 15);
            labelBSearchIterative_B.TabIndex = 20;
            labelBSearchIterative_B.Text = "Binary Search Iterative";
            // 
            // labelBSearchRecursive_B
            // 
            labelBSearchRecursive_B.AutoSize = true;
            labelBSearchRecursive_B.Location = new Point(559, 169);
            labelBSearchRecursive_B.Name = "labelBSearchRecursive_B";
            labelBSearchRecursive_B.Size = new Size(131, 15);
            labelBSearchRecursive_B.TabIndex = 21;
            labelBSearchRecursive_B.Text = "Binary Search Recursive";
            // 
            // labelSelectionSort_B
            // 
            labelSelectionSort_B.AutoSize = true;
            labelSelectionSort_B.Location = new Point(565, 294);
            labelSelectionSort_B.Name = "labelSelectionSort_B";
            labelSelectionSort_B.Size = new Size(79, 15);
            labelSelectionSort_B.TabIndex = 22;
            labelSelectionSort_B.Text = "Selection Sort";
            // 
            // labelInsertionSort_B
            // 
            labelInsertionSort_B.AutoSize = true;
            labelInsertionSort_B.Location = new Point(565, 397);
            labelInsertionSort_B.Name = "labelInsertionSort_B";
            labelInsertionSort_B.Size = new Size(77, 15);
            labelInsertionSort_B.TabIndex = 23;
            labelInsertionSort_B.Text = "Insertion Sort";
            // 
            // textBoxBSearchIterative_A
            // 
            textBoxBSearchIterative_A.Location = new Point(271, 101);
            textBoxBSearchIterative_A.Name = "textBoxBSearchIterative_A";
            textBoxBSearchIterative_A.Size = new Size(100, 23);
            textBoxBSearchIterative_A.TabIndex = 24;
            // 
            // textBoxBSearchRecursive_A
            // 
            textBoxBSearchRecursive_A.Location = new Point(271, 216);
            textBoxBSearchRecursive_A.Name = "textBoxBSearchRecursive_A";
            textBoxBSearchRecursive_A.Size = new Size(100, 23);
            textBoxBSearchRecursive_A.TabIndex = 25;
            // 
            // textBoxSelectionSort_A
            // 
            textBoxSelectionSort_A.Location = new Point(271, 341);
            textBoxSelectionSort_A.Name = "textBoxSelectionSort_A";
            textBoxSelectionSort_A.Size = new Size(100, 23);
            textBoxSelectionSort_A.TabIndex = 26;
            // 
            // textBoxInsertionSort_A
            // 
            textBoxInsertionSort_A.Location = new Point(271, 444);
            textBoxInsertionSort_A.Name = "textBoxInsertionSort_A";
            textBoxInsertionSort_A.Size = new Size(100, 23);
            textBoxInsertionSort_A.TabIndex = 27;
            // 
            // textBoxSearchTarget_A
            // 
            textBoxSearchTarget_A.Location = new Point(338, 256);
            textBoxSearchTarget_A.Name = "textBoxSearchTarget_A";
            textBoxSearchTarget_A.Size = new Size(44, 23);
            textBoxSearchTarget_A.TabIndex = 28;
            // 
            // labelSearch_A
            // 
            labelSearch_A.AutoSize = true;
            labelSearch_A.Location = new Point(271, 252);
            labelSearch_A.Name = "labelSearch_A";
            labelSearch_A.Size = new Size(45, 30);
            labelSearch_A.TabIndex = 29;
            labelSearch_A.Text = "Search \r\nTarget";
            // 
            // textBoxBSearchIterative_B
            // 
            textBoxBSearchIterative_B.Location = new Point(565, 113);
            textBoxBSearchIterative_B.Name = "textBoxBSearchIterative_B";
            textBoxBSearchIterative_B.Size = new Size(100, 23);
            textBoxBSearchIterative_B.TabIndex = 30;
            // 
            // textBoxBSearchRecursive_B
            // 
            textBoxBSearchRecursive_B.Location = new Point(565, 216);
            textBoxBSearchRecursive_B.Name = "textBoxBSearchRecursive_B";
            textBoxBSearchRecursive_B.Size = new Size(100, 23);
            textBoxBSearchRecursive_B.TabIndex = 31;
            textBoxBSearchRecursive_B.TextChanged += textBox7_TextChanged;
            // 
            // textBoxSelectionSort_B
            // 
            textBoxSelectionSort_B.Location = new Point(565, 341);
            textBoxSelectionSort_B.Name = "textBoxSelectionSort_B";
            textBoxSelectionSort_B.Size = new Size(100, 23);
            textBoxSelectionSort_B.TabIndex = 32;
            // 
            // textBoxInsertionSort_B
            // 
            textBoxInsertionSort_B.Location = new Point(565, 444);
            textBoxInsertionSort_B.Name = "textBoxInsertionSort_B";
            textBoxInsertionSort_B.Size = new Size(100, 23);
            textBoxInsertionSort_B.TabIndex = 33;
            // 
            // textBoxSearchTarget_B
            // 
            textBoxSearchTarget_B.Location = new Point(618, 259);
            textBoxSearchTarget_B.Name = "textBoxSearchTarget_B";
            textBoxSearchTarget_B.Size = new Size(47, 23);
            textBoxSearchTarget_B.TabIndex = 34;
            // 
            // labelSearch_B
            // 
            labelSearch_B.AutoSize = true;
            labelSearch_B.Location = new Point(565, 256);
            labelSearch_B.Name = "labelSearch_B";
            labelSearch_B.Size = new Size(42, 30);
            labelSearch_B.TabIndex = 35;
            labelSearch_B.Text = "Serach\r\nTarget";
            // 
            // labelSensorA
            // 
            labelSensorA.AutoSize = true;
            labelSensorA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSensorA.Location = new Point(289, 20);
            labelSensorA.Name = "labelSensorA";
            labelSensorA.Size = new Size(76, 21);
            labelSensorA.TabIndex = 36;
            labelSensorA.Text = "Sensor A";
            // 
            // labelSensorB
            // 
            labelSensorB.AutoSize = true;
            labelSensorB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSensorB.Location = new Point(585, 20);
            labelSensorB.Name = "labelSensorB";
            labelSensorB.Size = new Size(75, 21);
            labelSensorB.TabIndex = 37;
            labelSensorB.Text = "Sensor B";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 584);
            Controls.Add(labelSensorB);
            Controls.Add(labelSensorA);
            Controls.Add(labelSearch_B);
            Controls.Add(textBoxSearchTarget_B);
            Controls.Add(textBoxInsertionSort_B);
            Controls.Add(textBoxSelectionSort_B);
            Controls.Add(textBoxBSearchRecursive_B);
            Controls.Add(textBoxBSearchIterative_B);
            Controls.Add(labelSearch_A);
            Controls.Add(textBoxSearchTarget_A);
            Controls.Add(textBoxInsertionSort_A);
            Controls.Add(textBoxSelectionSort_A);
            Controls.Add(textBoxBSearchRecursive_A);
            Controls.Add(textBoxBSearchIterative_A);
            Controls.Add(labelInsertionSort_B);
            Controls.Add(labelSelectionSort_B);
            Controls.Add(labelBSearchRecursive_B);
            Controls.Add(labelBSearchIterative_B);
            Controls.Add(labelInsertionSort_A);
            Controls.Add(labelSelectionSort_A);
            Controls.Add(labelBSearchRecursive_A);
            Controls.Add(labelBSearchIterative_A);
            Controls.Add(btnInsertionSort_B);
            Controls.Add(btnSelectionSort_B);
            Controls.Add(btnBSearchRecursive_B);
            Controls.Add(btnBSearchIterative_B);
            Controls.Add(buttonInsertionSort_A);
            Controls.Add(btnSelectionSort_A);
            Controls.Add(buttonBSearchRecursive_A);
            Controls.Add(btnBSearchIterative_A);
            Controls.Add(listBoxSensorB);
            Controls.Add(listBoxSensorA);
            Controls.Add(labelMu);
            Controls.Add(labelSigma);
            Controls.Add(btnLoad);
            Controls.Add(numericUpDownMu);
            Controls.Add(numericUpDownSigma);
            Controls.Add(listViewBoth);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSigma).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewBoth;
        private NumericUpDown numericUpDownSigma;
        private NumericUpDown numericUpDownMu;
        private Button btnLoad;
        private Label labelSigma;
        private Label labelMu;
        private ListBox listBoxSensorA;
        private ListBox listBoxSensorB;
        private Button btnBSearchIterative_A;
        private Button buttonBSearchRecursive_A;
        private Button btnSelectionSort_A;
        private Button buttonInsertionSort_A;
        private Button btnBSearchIterative_B;
        private Button btnBSearchRecursive_B;
        private Button btnSelectionSort_B;
        private Button btnInsertionSort_B;
        private Label labelBSearchIterative_A;
        private Label labelBSearchRecursive_A;
        private Label labelSelectionSort_A;
        private Label labelInsertionSort_A;
        private Label labelBSearchIterative_B;
        private Label labelBSearchRecursive_B;
        private Label labelSelectionSort_B;
        private Label labelInsertionSort_B;
        private TextBox textBoxBSearchIterative_A;
        private TextBox textBoxBSearchRecursive_A;
        private TextBox textBoxSelectionSort_A;
        private TextBox textBoxInsertionSort_A;
        private TextBox textBoxSearchTarget_A;
        private Label labelSearch_A;
        private TextBox textBoxBSearchIterative_B;
        private TextBox textBoxBSearchRecursive_B;
        private TextBox textBoxSelectionSort_B;
        private TextBox textBoxInsertionSort_B;
        private TextBox textBoxSearchTarget_B;
        private Label labelSearch_B;
        private Label labelSensorA;
        private Label labelSensorB;
    }
}
