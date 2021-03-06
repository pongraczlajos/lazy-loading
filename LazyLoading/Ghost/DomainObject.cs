﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.Ghost
{
    public abstract class DomainObject
    {
        public LoadStatus Status { get; set; }

        public bool IsGhost
        {
            get { return Status == LoadStatus.Ghost; }
        }

        public bool IsLoaded
        {
            get { return Status == LoadStatus.Loaded; }
        }

        public void MarkLoading()
        {
            Status = LoadStatus.Loading;
        }

        public void MarkLoaded()
        {
            Status = LoadStatus.Loaded;
        }

        protected abstract void Load();
    }
}
