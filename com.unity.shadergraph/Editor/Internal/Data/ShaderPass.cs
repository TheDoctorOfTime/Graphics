﻿using System.Collections.Generic;

namespace UnityEditor.ShaderGraph.Internal
{
    public struct ShaderPass
    {
        // Definition
        public string displayName;
        public string referenceName;
        public string lightMode;
        public string passInclude;
        public string varyingsInclude;
        public bool useInPreview;

        // Setup
        public IEnumerable<string> pragmas;
        public IEnumerable<string> includes;
        public IEnumerable<string> defines;
        public IEnumerable<KeywordDescriptor> keywords;
        public IEnumerable<string> defaultDotsInstancingOptions;

        // Port mask
        public List<int> vertexPorts;
        public List<int> pixelPorts;

        // Required fields
        public List<string> requiredAttributes;
        public List<string> requiredVaryings;

        // Render State Overrides
        public string CullOverride;
        public string BlendOverride;
        public string BlendOpOverride;
        public string ZTestOverride;
        public string ZWriteOverride;
        public string ColorMaskOverride;
        public string ZClipOverride;
        public List<string> StencilOverride;

        // Custom Template
        public string passTemplatePath;
        public string sharedTemplateDirectory;

        // Methods
        public bool Equals(ShaderPass other)
        {
            return referenceName == other.referenceName;
        }
    }
}
