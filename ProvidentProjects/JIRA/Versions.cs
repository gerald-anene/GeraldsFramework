﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentProjects.JIRA
{
    public class Versions
    {
        public List<Version> UnreleasedVersions { get; set; }
        public List<Version> ReleasedVersions { get; set; }
    }
}
