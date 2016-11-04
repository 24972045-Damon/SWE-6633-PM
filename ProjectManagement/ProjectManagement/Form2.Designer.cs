﻿namespace ProjectManagementTool
{
    partial class Form2
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
            this.projectOverview = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxProjectOwner = new System.Windows.Forms.TextBox();
            this.labelprojectOwner = new System.Windows.Forms.Label();
            this.labelprojectName = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.tabControlHours = new System.Windows.Forms.TabControl();
            this.tabPageHours = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ReqAnalysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectMng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMembers = new System.Windows.Forms.TabPage();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageRequirements = new System.Windows.Forms.TabPage();
            this.buttonNewRequirement = new System.Windows.Forms.Button();
            this.dataGridRequirements = new System.Windows.Forms.DataGridView();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageRisk = new System.Windows.Forms.TabPage();
            this.TaskCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TaskDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditViewRisk = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRisk = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RequirementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequirmentPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequirementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequirementEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RequirementDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.TeamMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamMemberRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditViewMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.projectOverview.SuspendLayout();
            this.tabControlHours.SuspendLayout();
            this.tabPageHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).BeginInit();
            this.tabPageTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageRisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // projectOverview
            // 
            this.projectOverview.Controls.Add(this.buttonSave);
            this.projectOverview.Controls.Add(this.labelDescription);
            this.projectOverview.Controls.Add(this.textBoxDescription);
            this.projectOverview.Controls.Add(this.textBoxProjectOwner);
            this.projectOverview.Controls.Add(this.labelprojectOwner);
            this.projectOverview.Controls.Add(this.labelprojectName);
            this.projectOverview.Controls.Add(this.textBoxProjectName);
            this.projectOverview.Location = new System.Drawing.Point(31, 44);
            this.projectOverview.Name = "projectOverview";
            this.projectOverview.Size = new System.Drawing.Size(200, 392);
            this.projectOverview.TabIndex = 0;
            this.projectOverview.TabStop = false;
            this.projectOverview.Text = "Project Overvew";
            this.projectOverview.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(53, 338);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(43, 238);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(96, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Project Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(39, 270);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 1;
            // 
            // textBoxProjectOwner
            // 
            this.textBoxProjectOwner.Location = new System.Drawing.Point(39, 169);
            this.textBoxProjectOwner.Name = "textBoxProjectOwner";
            this.textBoxProjectOwner.Size = new System.Drawing.Size(100, 20);
            this.textBoxProjectOwner.TabIndex = 1;
            // 
            // labelprojectOwner
            // 
            this.labelprojectOwner.AutoSize = true;
            this.labelprojectOwner.Location = new System.Drawing.Point(54, 129);
            this.labelprojectOwner.Name = "labelprojectOwner";
            this.labelprojectOwner.Size = new System.Drawing.Size(74, 13);
            this.labelprojectOwner.TabIndex = 1;
            this.labelprojectOwner.Text = "Project Owner";
            // 
            // labelprojectName
            // 
            this.labelprojectName.AutoSize = true;
            this.labelprojectName.Location = new System.Drawing.Point(54, 45);
            this.labelprojectName.Name = "labelprojectName";
            this.labelprojectName.Size = new System.Drawing.Size(71, 13);
            this.labelprojectName.TabIndex = 1;
            this.labelprojectName.Text = "Project Name";
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Location = new System.Drawing.Point(39, 77);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProjectName.TabIndex = 1;
            // 
            // tabControlHours
            // 
            this.tabControlHours.Controls.Add(this.tabPageHours);
            this.tabControlHours.Controls.Add(this.tabPageMembers);
            this.tabControlHours.Controls.Add(this.tabPageRequirements);
            this.tabControlHours.Controls.Add(this.tabPageTasks);
            this.tabControlHours.Controls.Add(this.tabPageRisk);
            this.tabControlHours.Location = new System.Drawing.Point(251, 44);
            this.tabControlHours.Name = "tabControlHours";
            this.tabControlHours.SelectedIndex = 0;
            this.tabControlHours.Size = new System.Drawing.Size(622, 392);
            this.tabControlHours.TabIndex = 1;
            // 
            // tabPageHours
            // 
            this.tabPageHours.Controls.Add(this.dataGridView2);
            this.tabPageHours.Location = new System.Drawing.Point(4, 22);
            this.tabPageHours.Name = "tabPageHours";
            this.tabPageHours.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHours.Size = new System.Drawing.Size(614, 366);
            this.tabPageHours.TabIndex = 0;
            this.tabPageHours.Text = "Project Hours";
            this.tabPageHours.UseVisualStyleBackColor = true;
            this.tabPageHours.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReqAnalysis,
            this.Designing,
            this.Coding,
            this.Testing,
            this.ProjectMng,
            this.Total});
            this.dataGridView2.Location = new System.Drawing.Point(6, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(602, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // ReqAnalysis
            // 
            this.ReqAnalysis.HeaderText = "Requirement Analysis";
            this.ReqAnalysis.Name = "ReqAnalysis";
            // 
            // Designing
            // 
            this.Designing.HeaderText = "Designing";
            this.Designing.Name = "Designing";
            // 
            // Coding
            // 
            this.Coding.HeaderText = "Coding";
            this.Coding.Name = "Coding";
            // 
            // Testing
            // 
            this.Testing.HeaderText = "Testing";
            this.Testing.Name = "Testing";
            // 
            // ProjectMng
            // 
            this.ProjectMng.HeaderText = "Project Management";
            this.ProjectMng.Name = "ProjectMng";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // tabPageMembers
            // 
            this.tabPageMembers.Controls.Add(this.buttonCreateUser);
            this.tabPageMembers.Controls.Add(this.dataGridView1);
            this.tabPageMembers.Location = new System.Drawing.Point(4, 22);
            this.tabPageMembers.Name = "tabPageMembers";
            this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembers.Size = new System.Drawing.Size(614, 366);
            this.tabPageMembers.TabIndex = 1;
            this.tabPageMembers.Text = "Team Members";
            this.tabPageMembers.UseVisualStyleBackColor = true;
            this.tabPageMembers.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(241, 285);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(126, 23);
            this.buttonCreateUser.TabIndex = 1;
            this.buttonCreateUser.Text = "Create New";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamMemberName,
            this.TeamMemberRole,
            this.EditViewMember,
            this.DeleteMember});
            this.dataGridView1.Location = new System.Drawing.Point(85, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageRequirements
            // 
            this.tabPageRequirements.Controls.Add(this.buttonNewRequirement);
            this.tabPageRequirements.Controls.Add(this.dataGridRequirements);
            this.tabPageRequirements.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequirements.Name = "tabPageRequirements";
            this.tabPageRequirements.Size = new System.Drawing.Size(614, 366);
            this.tabPageRequirements.TabIndex = 2;
            this.tabPageRequirements.Text = "Requirements";
            this.tabPageRequirements.UseVisualStyleBackColor = true;
            // 
            // buttonNewRequirement
            // 
            this.buttonNewRequirement.Location = new System.Drawing.Point(248, 245);
            this.buttonNewRequirement.Name = "buttonNewRequirement";
            this.buttonNewRequirement.Size = new System.Drawing.Size(121, 23);
            this.buttonNewRequirement.TabIndex = 1;
            this.buttonNewRequirement.Text = "New Requirement";
            this.buttonNewRequirement.UseVisualStyleBackColor = true;
            // 
            // dataGridRequirements
            // 
            this.dataGridRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequirementName,
            this.RequirmentPriority,
            this.RequirementType,
            this.RequirementEdit,
            this.RequirementDelete});
            this.dataGridRequirements.Location = new System.Drawing.Point(32, 23);
            this.dataGridRequirements.Name = "dataGridRequirements";
            this.dataGridRequirements.Size = new System.Drawing.Size(548, 150);
            this.dataGridRequirements.TabIndex = 0;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.Controls.Add(this.button1);
            this.tabPageTasks.Controls.Add(this.dataGridView3);
            this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Size = new System.Drawing.Size(614, 366);
            this.tabPageTasks.TabIndex = 3;
            this.tabPageTasks.Text = "Tasks";
            this.tabPageTasks.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskDescription,
            this.TaskCategory,
            this.EditView,
            this.TaskDelete});
            this.dataGridView3.Location = new System.Drawing.Point(103, 70);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(442, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // TaskDescription
            // 
            this.TaskDescription.HeaderText = "Task Description";
            this.TaskDescription.Name = "TaskDescription";
            // 
            // tabPageRisk
            // 
            this.tabPageRisk.Controls.Add(this.button2);
            this.tabPageRisk.Controls.Add(this.dataGridView4);
            this.tabPageRisk.Location = new System.Drawing.Point(4, 22);
            this.tabPageRisk.Name = "tabPageRisk";
            this.tabPageRisk.Size = new System.Drawing.Size(614, 366);
            this.tabPageRisk.TabIndex = 4;
            this.tabPageRisk.Text = "Risk";
            this.tabPageRisk.UseVisualStyleBackColor = true;
            // 
            // TaskCategory
            // 
            this.TaskCategory.HeaderText = "Category";
            this.TaskCategory.Name = "TaskCategory";
            // 
            // EditView
            // 
            this.EditView.HeaderText = "Edit/View";
            this.EditView.Name = "EditView";
            // 
            // TaskDelete
            // 
            this.TaskDelete.HeaderText = "Delete";
            this.TaskDelete.Name = "TaskDelete";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Task";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Risk,
            this.RiskPriority,
            this.EditViewRisk,
            this.DeleteRisk});
            this.dataGridView4.Location = new System.Drawing.Point(90, 68);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(445, 150);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // Risk
            // 
            this.Risk.HeaderText = "Risk Description";
            this.Risk.Name = "Risk";
            // 
            // RiskPriority
            // 
            this.RiskPriority.HeaderText = "Priority";
            this.RiskPriority.Name = "RiskPriority";
            // 
            // EditViewRisk
            // 
            this.EditViewRisk.HeaderText = "Edit/View";
            this.EditViewRisk.Name = "EditViewRisk";
            // 
            // DeleteRisk
            // 
            this.DeleteRisk.HeaderText = "Delete";
            this.DeleteRisk.Name = "DeleteRisk";
            // 
            // RequirementName
            // 
            this.RequirementName.HeaderText = "Requirement Description";
            this.RequirementName.Name = "RequirementName";
            // 
            // RequirmentPriority
            // 
            this.RequirmentPriority.HeaderText = "Priority";
            this.RequirmentPriority.Name = "RequirmentPriority";
            // 
            // RequirementType
            // 
            this.RequirementType.HeaderText = "Type";
            this.RequirementType.Name = "RequirementType";
            // 
            // RequirementEdit
            // 
            this.RequirementEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RequirementEdit.HeaderText = "Edit/View";
            this.RequirementEdit.Name = "RequirementEdit";
            this.RequirementEdit.Text = "Edit";
            this.RequirementEdit.UseColumnTextForButtonValue = true;
            // 
            // RequirementDelete
            // 
            this.RequirementDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RequirementDelete.HeaderText = "Delete";
            this.RequirementDelete.Name = "RequirementDelete";
            this.RequirementDelete.Text = "Delete";
            this.RequirementDelete.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Risk";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TeamMemberName
            // 
            this.TeamMemberName.HeaderText = "Name";
            this.TeamMemberName.Name = "TeamMemberName";
            // 
            // TeamMemberRole
            // 
            this.TeamMemberRole.HeaderText = "Role";
            this.TeamMemberRole.Name = "TeamMemberRole";
            // 
            // EditViewMember
            // 
            this.EditViewMember.HeaderText = "Edit/View";
            this.EditViewMember.Name = "EditViewMember";
            this.EditViewMember.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditViewMember.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteMember
            // 
            this.DeleteMember.HeaderText = "Delete";
            this.DeleteMember.Name = "DeleteMember";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 496);
            this.Controls.Add(this.tabControlHours);
            this.Controls.Add(this.projectOverview);
            this.Name = "Form2";
            this.Text = "Project Manager 2016";
            this.projectOverview.ResumeLayout(false);
            this.projectOverview.PerformLayout();
            this.tabControlHours.ResumeLayout(false);
            this.tabPageHours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRequirements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).EndInit();
            this.tabPageTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageRisk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox projectOverview;
        private System.Windows.Forms.Label labelprojectName;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxProjectOwner;
        private System.Windows.Forms.Label labelprojectOwner;
        private System.Windows.Forms.TabControl tabControlHours;
        private System.Windows.Forms.TabPage tabPageHours;
        private System.Windows.Forms.TabPage tabPageMembers;
        private System.Windows.Forms.TabPage tabPageRequirements;
        private System.Windows.Forms.TabPage tabPageTasks;
        private System.Windows.Forms.TabPage tabPageRisk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button buttonNewRequirement;
        private System.Windows.Forms.DataGridView dataGridRequirements;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqAnalysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectMng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCategory;
        private System.Windows.Forms.DataGridViewButtonColumn EditView;
        private System.Windows.Forms.DataGridViewButtonColumn TaskDelete;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirmentPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementType;
        private System.Windows.Forms.DataGridViewButtonColumn RequirementEdit;
        private System.Windows.Forms.DataGridViewButtonColumn RequirementDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskPriority;
        private System.Windows.Forms.DataGridViewButtonColumn EditViewRisk;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRisk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamMemberRole;
        private System.Windows.Forms.DataGridViewButtonColumn EditViewMember;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteMember;
    }
}