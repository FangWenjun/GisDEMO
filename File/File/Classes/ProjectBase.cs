﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File;
using System.IO;
using System.Windows.Forms;

namespace File.Classes
{
    public class ProjectBase
    {
        public event EventHandler<EventArgs> ProjectChanged;

        protected virtual void OnProjectChanged()
        {
            EventHandler<EventArgs> handler = ProjectChanged;
            if (handler != null) handler(this, new EventArgs());
        }

        internal ProjectBase()
        {
            SetEmptyProject();
        }

        protected string Filename { get; set; }

        private void SetEmptyProject()
        {
            Filename = "";
            OnProjectChanged();
        }

        protected ProjectState State
        {
            get
            {
                if (App.Map.GeoProjection.IsEmpty && App.Map.NumLayers == 0) return ProjectState.Empty;

                if (string.IsNullOrWhiteSpace(Filename)) return ProjectState.NotSaved;
                try
                {
                    using (var r = new StreamReader(Filename))
                    {
                        string oldState = r.ReadToEnd();
                        string state = App.Map.SerializeMapState(true, Filename);
                        return state.ToLower() != oldState.ToLower() ? ProjectState.HasChanges : ProjectState.NoChanges;
                    }
                }
                catch
                {
                    return ProjectState.NotSaved;
                }
            }
        }

        protected bool TryCloseProject()
        {
            var state = State;
            switch (state)
            {
                case ProjectState.NotSaved:
                case ProjectState.HasChanges:
                    string prompt = "Save the project?";
                    if (!string.IsNullOrWhiteSpace(Filename))
                        prompt = string.Format("Save the project: {0}?", Path.GetFileName(Filename));

                    var result = MessageHelper.AskYesNoCancel(prompt);
                    if (result == DialogResult.Cancel) return false;
                    if (result == DialogResult.Yes)
                        SaveCurrentProject();
                    break;
                case ProjectState.NoChanges:
                case ProjectState.Empty:
                    break;
            }
            SetEmptyProject();
            return true;
        }

        protected bool SaveCurrentProject()
        {
            string filename = Filename;
            bool newProject = State == ProjectState.NotSaved;
            if (newProject)
            {
                if (!FileHelper.ShowSaveDialog(FileType.Project, ref filename))
                    return false;
            }
            SaveInternal(filename);

            if (newProject)
                OnProjectChanged();

            return true;
        }

        protected void SaveProjectAs()
        {
            string filename = Filename;
            if (!FileHelper.ShowSaveDialog(FileType.Project, ref filename))
                return;
            SaveInternal(filename);
            OnProjectChanged();
        }

        private void SaveInternal(string filename)
        {
            bool saved = App.Map.SaveMapState(filename, true, true);
            if (!saved)
                MessageHelper.Warn("Failed to save project.");
            else
                Filename = filename;
        }

        protected void LoadProject(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename)) return;

            if (!System.IO.File.Exists(filename))
            {
                MessageHelper.Info("The last project file wasn't found: " + filename);
                return;
            }

            App.LoadMapState(filename);
       //     App.Legend.AssignOrphanLayersToNewGroup(DEFAULT_GROUP_NAME);
            Filename = filename;

            OnProjectChanged();
        }

    }
}
