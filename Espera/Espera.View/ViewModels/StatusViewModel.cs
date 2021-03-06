﻿using Espera.Core.Library;
using Rareform.Patterns.MVVM;

namespace Espera.View.ViewModels
{
    internal class StatusViewModel : ViewModelBase<StatusViewModel>
    {
        private string path;
        private int processedTags;
        private int totalTags;
        private bool isAdding;
        private bool isUpdating;
        private Library library;

        public bool IsUpdating
        {
            get { return this.isUpdating; }
            set
            {
                if (this.isUpdating != value)
                {
                    this.isUpdating = value;
                    this.OnPropertyChanged(vm => vm.IsUpdating);
                }
            }
        }

        public string Path
        {
            get { return this.path; }
            private set
            {
                if (this.Path != value)
                {
                    this.path = value;
                    this.OnPropertyChanged(vm => vm.Path);
                }
            }
        }

        public int ProcessedTags
        {
            get { return this.processedTags; }
            private set
            {
                if (this.ProcessedTags != value)
                {
                    this.processedTags = value;
                    this.OnPropertyChanged(vm => vm.ProcessedTags);
                }
            }
        }

        public int TotalTags
        {
            get { return this.totalTags; }
            private set
            {
                if (this.totalTags != value)
                {
                    this.totalTags = value;
                    this.OnPropertyChanged(vm => vm.TotalTags);
                }
            }
        }

        public bool IsAdding
        {
            get { return this.isAdding; }
            set
            {
                if (this.IsAdding != value)
                {
                    this.isAdding = value;
                    this.OnPropertyChanged(vm => vm.IsAdding);
                    this.OnPropertyChanged(vm => vm.IsProgressUnkown);
                }
            }
        }

        public bool IsProgressUnkown
        {
            get { return this.ProcessedTags == this.TotalTags && this.IsAdding; }
        }

        public StatusViewModel(Library library)
        {
            this.library = library;
            this.library.Updating += (sender, e) => this.IsUpdating = true;
            this.library.Updated += (sender, args) => this.IsUpdating = false;
        }

        public void Update(string path, int processedTags, int totalTags)
        {
            this.Path = path;
            this.ProcessedTags = processedTags;
            this.TotalTags = totalTags;

            this.OnPropertyChanged(vm => vm.IsProgressUnkown);
        }

        public void Reset()
        {
            this.Path = null;
            this.ProcessedTags = 0;
            this.TotalTags = 0;
            this.IsAdding = false;
        }
    }
}