using System.Text;

namespace SemanticVersionSort
{
    public class SemanticVersionEntity
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Patch { get; set; }
        public string Label { get; set; }
        public string Metadata { get; set; }

        public static bool operator <(SemanticVersionEntity first, SemanticVersionEntity second)
        {
            // Sorting rules
            //1. First, compare the major version.
            //2. If they are the same, compare the minor version.
            //3. If they are the same, compare the patch version.
            //3. If those are all the same, check if the version has a label - ignore the 
            // content of the label. A version with a label (prerelease) comes before one 
            // without a label (final release.)
            //5. Ignore the build metadata.

            if (first.Major < second.Major)
            {
                return true;
            }

            if (first.Major > second.Major)
            {
                return false;
            }

            if (first.Minor < second.Minor)
            {
                return true;
            }
            
            if (first.Minor > second.Minor)
            {
                return false;
            }

            if (first.Patch < second.Patch)
            {
                return true;
            }

            if (first.Patch > second.Patch)
            {
                return false;
            }

            return !string.IsNullOrEmpty(first.Label);
        }

        public static bool operator >(SemanticVersionEntity first, SemanticVersionEntity second)
        {
            if (first.Major > second.Major)
            {
                return true;
            }

            if (first.Minor > second.Minor)
            {
                return true;
            }

            if (first.Patch > second.Patch)
            {
                return true;
            }

            return string.IsNullOrEmpty(first.Label);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0}.{1}.{2}", Major, Minor, Patch));
            
            if (!string.IsNullOrEmpty(Label))
            {
                output.Append(string.Format("-{0}", Label));
            }

            if (!string.IsNullOrEmpty(Metadata))
            {
                output.Append(string.Format("+{0}", Metadata));
            }

            return output.ToString();
        }
    }
}
