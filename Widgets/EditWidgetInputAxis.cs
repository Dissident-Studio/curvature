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
    public partial class EditWidgetInputAxis : UserControl
    {
        private InputAxis EditedAxis;
        private Project EditedProject;


        internal delegate void DialogRebuildNeededHandler();
        internal event DialogRebuildNeededHandler DialogRebuildNeeded;


        internal EditWidgetInputAxis(Project project, InputAxis axis)
        {
            InitializeComponent();
            EditedAxis = axis;
            EditedProject = project;

            EditedAxis.DialogRebuildNeeded += Rebuild;

            NameEditWidget.Attach("Input Axis", axis, project);

            InputTypeComboBox.SelectedIndex = (int)axis.Origin;

            EditedAxis.ParametersChanged += (obj, args) =>
            {
                GenerateParameterControls();
                EditedProject.MarkDirty();
            };
        }

        private void InputTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectComputedProperties = false;
            DataSourceComboBox.Items.Clear();

            if (InputTypeComboBox.SelectedIndex == 0 || InputTypeComboBox.SelectedIndex == 1)
            {
                selectComputedProperties = false;
            }
            else if (InputTypeComboBox.SelectedIndex == 2)
            {
                selectComputedProperties = true;
            }

            foreach (var rec in EditedProject.KB.Records)
            {
                if (rec.Computed == selectComputedProperties)
                    DataSourceComboBox.Items.Add(rec);
            }

            var prev = EditedAxis.Origin;

            DataSourceComboBox.SelectedItem = EditedAxis.KBRec;
            EditedAxis.Origin = (InputAxis.OriginType)InputTypeComboBox.SelectedIndex;

            GenerateParameterControls();


            if (prev != EditedAxis.Origin)
                EditedProject.MarkDirty();
        }

        private void DataSourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var prev = EditedAxis.KBRec;

            EditedAxis.KBRec = DataSourceComboBox.SelectedItem as KnowledgeBase.Record;

            if (prev != EditedAxis.KBRec)
                EditedProject.MarkDirty();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            EditedProject.Delete(EditedAxis);
        }

        private void GenerateParameterControls()
        {
            foreach (Control ctl in ParamFlowPanel.Controls)
                ctl.Dispose();

            ParamFlowPanel.Controls.Clear();

            foreach (InputParameter param in EditedAxis.Parameters)
            {
                ParamFlowPanel.Controls.Add(new EditWidgetParameter(param, EditedProject));
            }
        }


        internal void Rebuild()
        {
            NameEditWidget.Attach("Input Axis", EditedAxis, EditedProject);
            DialogRebuildNeeded?.Invoke();
        }
    }
}
