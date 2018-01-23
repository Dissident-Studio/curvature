﻿namespace Curvature.Widgets
{
    partial class EditWidgetArchetypes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWidgetArchetypes));
            this.DeleteArchetypesButton = new System.Windows.Forms.Button();
            this.AddArchetypeButton = new System.Windows.Forms.Button();
            this.ArchetypesListView = new System.Windows.Forms.ListView();
            this.ArchetypeNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IconImageList = new System.Windows.Forms.ImageList(this.components);
            this.ArchetypeEditWidget = new Curvature.EditWidgetArchetype();
            this.SuspendLayout();
            // 
            // DeleteArchetypesButton
            // 
            this.DeleteArchetypesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteArchetypesButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteArchetypesButton.ImageIndex = 1;
            this.DeleteArchetypesButton.ImageList = this.IconImageList;
            this.DeleteArchetypesButton.Location = new System.Drawing.Point(128, 573);
            this.DeleteArchetypesButton.Name = "DeleteArchetypesButton";
            this.DeleteArchetypesButton.Size = new System.Drawing.Size(119, 52);
            this.DeleteArchetypesButton.TabIndex = 9;
            this.DeleteArchetypesButton.Text = "Delete Selection";
            this.DeleteArchetypesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteArchetypesButton.UseVisualStyleBackColor = true;
            this.DeleteArchetypesButton.Click += new System.EventHandler(this.DeleteArchetypesButton_Click);
            // 
            // AddArchetypeButton
            // 
            this.AddArchetypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddArchetypeButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddArchetypeButton.ImageIndex = 0;
            this.AddArchetypeButton.ImageList = this.IconImageList;
            this.AddArchetypeButton.Location = new System.Drawing.Point(3, 573);
            this.AddArchetypeButton.Name = "AddArchetypeButton";
            this.AddArchetypeButton.Size = new System.Drawing.Size(119, 52);
            this.AddArchetypeButton.TabIndex = 7;
            this.AddArchetypeButton.Text = "Create Archetype";
            this.AddArchetypeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddArchetypeButton.UseVisualStyleBackColor = true;
            this.AddArchetypeButton.Click += new System.EventHandler(this.AddArchetypeButton_Click);
            // 
            // ArchetypesListView
            // 
            this.ArchetypesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ArchetypesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ArchetypeNameColumn});
            this.ArchetypesListView.FullRowSelect = true;
            this.ArchetypesListView.HideSelection = false;
            this.ArchetypesListView.Location = new System.Drawing.Point(3, 3);
            this.ArchetypesListView.Name = "ArchetypesListView";
            this.ArchetypesListView.Size = new System.Drawing.Size(244, 564);
            this.ArchetypesListView.TabIndex = 6;
            this.ArchetypesListView.UseCompatibleStateImageBehavior = false;
            this.ArchetypesListView.View = System.Windows.Forms.View.Details;
            this.ArchetypesListView.SelectedIndexChanged += new System.EventHandler(this.ArchetypesListView_SelectedIndexChanged);
            // 
            // ArchetypeNameColumn
            // 
            this.ArchetypeNameColumn.Text = "Archetype Name";
            this.ArchetypeNameColumn.Width = 220;
            // 
            // IconImageList
            // 
            this.IconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconImageList.ImageStream")));
            this.IconImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IconImageList.Images.SetKeyName(0, "CreateItemIcon.png");
            this.IconImageList.Images.SetKeyName(1, "DeleteItemIcon.png");
            // 
            // ArchetypeEditWidget
            // 
            this.ArchetypeEditWidget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArchetypeEditWidget.Location = new System.Drawing.Point(253, 3);
            this.ArchetypeEditWidget.Name = "ArchetypeEditWidget";
            this.ArchetypeEditWidget.Size = new System.Drawing.Size(685, 622);
            this.ArchetypeEditWidget.TabIndex = 8;
            this.ArchetypeEditWidget.Visible = false;
            // 
            // EditWidgetArchetypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteArchetypesButton);
            this.Controls.Add(this.AddArchetypeButton);
            this.Controls.Add(this.ArchetypeEditWidget);
            this.Controls.Add(this.ArchetypesListView);
            this.Name = "EditWidgetArchetypes";
            this.Size = new System.Drawing.Size(941, 628);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteArchetypesButton;
        private System.Windows.Forms.Button AddArchetypeButton;
        private EditWidgetArchetype ArchetypeEditWidget;
        private System.Windows.Forms.ListView ArchetypesListView;
        private System.Windows.Forms.ColumnHeader ArchetypeNameColumn;
        private System.Windows.Forms.ImageList IconImageList;
    }
}
