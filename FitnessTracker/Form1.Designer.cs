namespace FitnessTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbWorkoutType = new ComboBox();
            cmbDuration = new ComboBox();
            txtCaloriesBurned = new TextBox();
            txtStepsTaken = new TextBox();
            chkEasy = new CheckBox();
            chkMedium = new CheckBox();
            chkHard = new CheckBox();
            chkExtreme = new CheckBox();
            trackTargetValue = new TrackBar();
            lblTargetValue = new Label();
            dtpDeadline = new DateTimePicker();
            btnLogWorkout = new Button();
            btnSetGoal = new Button();
            btnViewProgress = new Button();
            lblWorkoutType = new Label();
            lblDuration = new Label();
            lblCaloriesBurned = new Label();
            lblStepsTaken = new Label();
            lblGoalType = new Label();
            lblTarget = new Label();
            lblDeadline = new Label();
            ((System.ComponentModel.ISupportInitialize)trackTargetValue).BeginInit();
            SuspendLayout();
            // 
            // cmbWorkoutType
            // 
            cmbWorkoutType.FormattingEnabled = true;
            cmbWorkoutType.Location = new Point(50, 70);
            cmbWorkoutType.Name = "cmbWorkoutType";
            cmbWorkoutType.Size = new Size(200, 28);
            cmbWorkoutType.TabIndex = 0;
            // 
            // cmbDuration
            // 
            cmbDuration.FormattingEnabled = true;
            cmbDuration.Location = new Point(50, 140);
            cmbDuration.Name = "cmbDuration";
            cmbDuration.Size = new Size(200, 28);
            cmbDuration.TabIndex = 1;
            // 
            // txtCaloriesBurned
            // 
            txtCaloriesBurned.Location = new Point(50, 210);
            txtCaloriesBurned.Name = "txtCaloriesBurned";
            txtCaloriesBurned.PlaceholderText = "Enter calories burned";
            txtCaloriesBurned.Size = new Size(200, 27);
            txtCaloriesBurned.TabIndex = 2;
            // 
            // txtStepsTaken
            // 
            txtStepsTaken.Location = new Point(50, 280);
            txtStepsTaken.Name = "txtStepsTaken";
            txtStepsTaken.PlaceholderText = "Enter steps taken";
            txtStepsTaken.Size = new Size(200, 27);
            txtStepsTaken.TabIndex = 3;
            // 
            // chkEasy
            // 
            chkEasy.AutoSize = true;
            chkEasy.Location = new Point(300, 70);
            chkEasy.Name = "chkEasy";
            chkEasy.Size = new Size(60, 24);
            chkEasy.TabIndex = 4;
            chkEasy.Text = "Easy";
            // 
            // chkMedium
            // 
            chkMedium.AutoSize = true;
            chkMedium.Location = new Point(300, 100);
            chkMedium.Name = "chkMedium";
            chkMedium.Size = new Size(86, 24);
            chkMedium.TabIndex = 5;
            chkMedium.Text = "Medium";
            // 
            // chkHard
            // 
            chkHard.AutoSize = true;
            chkHard.Location = new Point(300, 130);
            chkHard.Name = "chkHard";
            chkHard.Size = new Size(64, 24);
            chkHard.TabIndex = 6;
            chkHard.Text = "Hard";
            // 
            // chkExtreme
            // 
            chkExtreme.AutoSize = true;
            chkExtreme.Location = new Point(300, 160);
            chkExtreme.Name = "chkExtreme";
            chkExtreme.Size = new Size(85, 24);
            chkExtreme.TabIndex = 7;
            chkExtreme.Text = "Extreme";
            // 
            // trackTargetValue
            // 
            trackTargetValue.Location = new Point(300, 210);
            trackTargetValue.Name = "trackTargetValue";
            trackTargetValue.Size = new Size(200, 56);
            trackTargetValue.TabIndex = 8;
            trackTargetValue.Scroll += trackTargetValue_Scroll;
            // 
            // lblTargetValue
            // 
            lblTargetValue.AutoSize = true;
            lblTargetValue.Location = new Point(510, 220);
            lblTargetValue.Name = "lblTargetValue";
            lblTargetValue.Size = new Size(37, 20);
            lblTargetValue.TabIndex = 9;
            lblTargetValue.Text = "50%";
            // 
            // dtpDeadline
            // 
            dtpDeadline.Location = new Point(300, 280);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(200, 27);
            dtpDeadline.TabIndex = 10;
            // 
            // btnLogWorkout
            // 
            btnLogWorkout.Location = new Point(50, 330);
            btnLogWorkout.Name = "btnLogWorkout";
            btnLogWorkout.Size = new Size(200, 35);
            btnLogWorkout.TabIndex = 11;
            btnLogWorkout.Text = "Log Workout";
            btnLogWorkout.UseVisualStyleBackColor = true;
            btnLogWorkout.Click += btnLogWorkout_Click;
            // 
            // btnSetGoal
            // 
            btnSetGoal.Location = new Point(300, 330);
            btnSetGoal.Name = "btnSetGoal";
            btnSetGoal.Size = new Size(200, 35);
            btnSetGoal.TabIndex = 12;
            btnSetGoal.Text = "Set Goal";
            btnSetGoal.UseVisualStyleBackColor = true;
            btnSetGoal.Click += btnSetGoal_Click;
            // 
            // btnViewProgress
            // 
            btnViewProgress.Location = new Point(175, 380);
            btnViewProgress.Name = "btnViewProgress";
            btnViewProgress.Size = new Size(200, 35);
            btnViewProgress.TabIndex = 13;
            btnViewProgress.Text = "View Progress";
            btnViewProgress.UseVisualStyleBackColor = true;
            btnViewProgress.Click += btnViewProgress_Click;
            // 
            // lblWorkoutType
            // 
            lblWorkoutType.AutoSize = true;
            lblWorkoutType.Location = new Point(50, 40);
            lblWorkoutType.Name = "lblWorkoutType";
            lblWorkoutType.Size = new Size(100, 20);
            lblWorkoutType.TabIndex = 14;
            lblWorkoutType.Text = "Workout Type";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(50, 110);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(67, 20);
            lblDuration.TabIndex = 15;
            lblDuration.Text = "Duration";
            // 
            // lblCaloriesBurned
            // 
            lblCaloriesBurned.AutoSize = true;
            lblCaloriesBurned.Location = new Point(50, 180);
            lblCaloriesBurned.Name = "lblCaloriesBurned";
            lblCaloriesBurned.Size = new Size(113, 20);
            lblCaloriesBurned.TabIndex = 16;
            lblCaloriesBurned.Text = "Calories Burned";
            // 
            // lblStepsTaken
            // 
            lblStepsTaken.AutoSize = true;
            lblStepsTaken.Location = new Point(50, 250);
            lblStepsTaken.Name = "lblStepsTaken";
            lblStepsTaken.Size = new Size(86, 20);
            lblStepsTaken.TabIndex = 17;
            lblStepsTaken.Text = "Steps Taken";
            // 
            // lblGoalType
            // 
            lblGoalType.AutoSize = true;
            lblGoalType.Location = new Point(300, 40);
            lblGoalType.Name = "lblGoalType";
            lblGoalType.Size = new Size(75, 20);
            lblGoalType.TabIndex = 18;
            lblGoalType.Text = "Goal Type";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(367, 187);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(90, 20);
            lblTarget.TabIndex = 19;
            lblTarget.Text = "Target Value";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(300, 250);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(69, 20);
            lblDeadline.TabIndex = 20;
            lblDeadline.Text = "Deadline";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(lblDeadline);
            Controls.Add(lblTarget);
            Controls.Add(lblGoalType);
            Controls.Add(lblStepsTaken);
            Controls.Add(lblCaloriesBurned);
            Controls.Add(lblDuration);
            Controls.Add(lblWorkoutType);
            Controls.Add(btnViewProgress);
            Controls.Add(btnSetGoal);
            Controls.Add(btnLogWorkout);
            Controls.Add(dtpDeadline);
            Controls.Add(lblTargetValue);
            Controls.Add(trackTargetValue);
            Controls.Add(chkExtreme);
            Controls.Add(chkHard);
            Controls.Add(chkMedium);
            Controls.Add(chkEasy);
            Controls.Add(txtStepsTaken);
            Controls.Add(txtCaloriesBurned);
            Controls.Add(cmbDuration);
            Controls.Add(cmbWorkoutType);
            Name = "Form1";
            Text = "Fitness Tracker";
            ((System.ComponentModel.ISupportInitialize)trackTargetValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorkoutType;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.TextBox txtCaloriesBurned;
        private System.Windows.Forms.TextBox txtStepsTaken;
        private System.Windows.Forms.CheckBox chkEasy;
        private System.Windows.Forms.CheckBox chkMedium;
        private System.Windows.Forms.CheckBox chkHard;
        private System.Windows.Forms.CheckBox chkExtreme;
        private System.Windows.Forms.TrackBar trackTargetValue;
        private System.Windows.Forms.Label lblTargetValue;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnLogWorkout;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.Button btnViewProgress;
        private System.Windows.Forms.Label lblWorkoutType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblCaloriesBurned;
        private System.Windows.Forms.Label lblStepsTaken;
        private System.Windows.Forms.Label lblGoalType;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblDeadline;
    }
}