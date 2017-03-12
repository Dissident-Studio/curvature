﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public partial class EditWidgetConsideration : UserControl
    {
        private Consideration EditConsideration;
        private Project EditProject;

        internal EditWidgetConsideration(Project project, Consideration editConsideration)
        {
            InitializeComponent();
            EditConsideration = editConsideration;
            EditProject = project;

            ConsiderationNameLabel.Text = "Consideration: " + EditConsideration.ReadableName;

            foreach (InputAxis axis in project.Inputs)
            {
                InputAxisDropdown.Items.Add(axis);
            }

            foreach (InputParameter param in EditConsideration.Parameters)
            {
                ParamFlowPanel.Controls.Add(new EditWidgetParameter(param));
            }

            InputAxisDropdown.SelectedItem = EditConsideration.Input;
            ResponseCurveEditor.AttachCurve(EditConsideration.Curve);
        }

        private void CurveWizardButton_Click(object sender, EventArgs e)
        {
            (new CurveWizardForm(EditProject, EditConsideration)).ShowDialog();
        }
    }
}
